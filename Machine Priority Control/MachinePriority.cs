using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Priority_Control {
  public partial class MachinePriority : Form {
    private List<ListBox> lbs = new List<ListBox>();
    public MachinePriority() {
      InitializeComponent();
      checkBox1.Checked = false;
      lbs.AddRange(new ListBox[] { listBox1, listBox2, listBox3, listBox4 });
    }

    public MachinePriority(string pre_selected_part) {
      PreSelectedPart = pre_selected_part;
      InitializeComponent();
      Text = PreSelectedPart;
      lbs.AddRange(new ListBox[] { listBox1, listBox2, listBox3, listBox4 });
      cUTPARTSBindingSource.Filter = string.Format(@"PARTNUM LIKE '{0}'", PreSelectedPart);
    }

    public Dictionary<int, int> get_priority_values() {
      int p = 0;
      if (comboBox1.SelectedValue != null &&
        int.TryParse(comboBox1.SelectedValue.ToString(), out p)) {
        return ENGINEERINGDataSet.get_priority_values_inner(p);
      }
      return new Dictionary<int, int>();
    }

    private void get_priorities() {
      listBox1.ClearSelected();
      listBox2.ClearSelected();
      listBox3.ClearSelected();
      listBox4.ClearSelected();
      foreach (KeyValuePair<int, int> item in get_priority_values()) {
        switch (item.Value) {
          case 3:
            listBox3.SetSelected(
              listBox3.FindString(get_name_of_machine(item.Key)),
              true);
            break;
          case 2:
            listBox2.SetSelected(
              listBox2.FindString(get_name_of_machine(item.Key)),
              true);
            break;
          case 1:
            listBox1.SetSelected(
              listBox1.FindString(get_name_of_machine(item.Key)),
              true);
            break;
          case 0:
            listBox4.SetSelected(
              listBox4.FindString(get_name_of_machine(item.Key)),
            true);
            break;
          default:
            break;
        }
      }
    }

    private string get_name_of_machine(int machid) {
      string res = string.Empty;
      try {
        res = cUT_MACHINESTableAdapter.GetMachnameByID(machid);
      } catch (NullReferenceException) {
        //
      }
      return res;
    }

    public Dictionary<int, int> get_listbox_states() {
      Dictionary<int, int> d = new Dictionary<int, int>();
      for (int i = 0; i < listBox1.Items.Count; i++) {
        DataRowView item = (DataRowView)listBox1.Items[i];
        try {
          if (!listBox1.GetSelected(i) &&
              !listBox2.GetSelected(i) &&
              !listBox3.GetSelected(i) &&
              !listBox4.GetSelected(i)) {
            d.Add((int)item[0], -1);
          }

          if (listBox4.GetSelected(i))
            d.Add((int)item[0], 0);

          if (listBox1.GetSelected(i))
            d.Add((int)item[0], 1);

          if (listBox2.GetSelected(i))
            d.Add((int)item[0], 2);

          if (listBox3.GetSelected(i))
            d.Add((int)item[0], 3);
        } catch (ArgumentException) {
          // Key already exists
        }
      }
      return d;
    }

    private void toggle_filter(bool on) {
      if (on) {
        cUTPARTSBindingSource.Filter = string.Format("PARTNUM LIKE '{0}'", PreSelectedPart);
        update_common_parts();
      } else {
        cUTPARTSBindingSource.Filter = string.Empty;
        comboBox1.DataSource = cUTPARTSBindingSource;
        int si = comboBox1.FindString(PreSelectedPart);
        if (si > -1) {
          comboBox1.SelectedIndex = si;
        }
      }
    }

    private void apply_changes() {
      DataRowView comboboxitem = (DataRowView)comboBox1.SelectedItem;
      ENGINEERINGDataSet.update_priority_values((int)comboboxitem[0], get_listbox_states());
    }

    private void update_common_parts() {
      System.Text.RegularExpressions.MatchCollection cnc1;
      System.Text.RegularExpressions.MatchCollection cnc2;
      System.Text.RegularExpressions.Regex rx =
        new System.Text.RegularExpressions.Regex(Properties.Settings.Default.CNCProgramRegex);

      if (comboBox1.SelectedItem != null) {
        cnc1 = rx.Matches((comboBox1.SelectedItem as DataRowView)[@"CNC1"].ToString());
        cnc2 = rx.Matches((comboBox1.SelectedItem as DataRowView)[@"CNC2"].ToString());
        string cnc1string = string.Empty;
        string cnc2string = string.Empty;
        if (cnc1.Count > 0) {
          cnc1string = '%' + cnc1[0].Value + '%';
        }

        if (cnc2.Count > 0) {
          cnc2string = '%' + cnc2[0].Value + '%';
        }
        ENGINEERINGDataSet.CUT_PARTSDataTable c = cUT_PARTSTableAdapter.GetDataByCNCProg(cnc1string, cnc2string);
        listBox5.DataSource = c;
        if (checkBox1.Checked && cnc1string != string.Empty) {
          comboBox1.DataSource = c;
        }
      }
    }

    public string PreSelectedPart { get; set; }

    private void buttonApply_Click(object sender, EventArgs e) {
      apply_changes();
    }

    private void buttonOK_Click(object sender, EventArgs e) {
      apply_changes();
      Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e) {
      Close();
    }

    private void Form1_Load(object sender, EventArgs e) {
      Size = Properties.Settings.Default.FormSize;
      Location = Properties.Settings.Default.FormLocation;
#if DEBUG
      Show();
#endif
      // TODO: This line of code loads data into the 'eNGINEERINGDataSet.CUT_MACHINE_PROGRAMS' table. You can move, or remove it, as needed.
      //this.cUT_MACHINE_PROGRAMSTableAdapter.Fill(this.eNGINEERINGDataSet.CUT_MACHINE_PROGRAMS);
      this.cUT_PARTSTableAdapter.Fill(this.eNGINEERINGDataSet.CUT_PARTS);
      this.cUT_MACHINESTableAdapter.Fill(this.eNGINEERINGDataSet.CUT_MACHINES);
      get_priorities();
      if (comboBox1.Items.Count < 1) {
        if (PreSelectedPart.Length == 0) {
          PreSelectedPart = "NULL";
        }
        string message = string.Format(Properties.Settings.Default.PartNotInCutlistMessage, PreSelectedPart);
        string title = Properties.Settings.Default.PartNotInCutlistText;
        System.Windows.Forms.MessageBox.Show(message, title, MessageBoxButtons.OK);
        Close();
      }
      update_common_parts();
      listBox5.Focus();
    }

    private void MachinePriority_FormClosing(object sender, FormClosingEventArgs e) {
      ENGINEERINGDataSetTableAdapters.QueriesTableAdapter qta = new ENGINEERINGDataSetTableAdapters.QueriesTableAdapter();
      int user = (int)qta.GetCurrentAuthor(Environment.UserName);
      if (qta.IncrementOdometer(10, user) < 1) {
        qta.CreateOdometerEntry(1, 10, user);
      }
      Properties.Settings.Default.FormSize = Size;
      Properties.Settings.Default.FormLocation = Location;
      Properties.Settings.Default.Save();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      if (!(comboBox1.DataSource is BindingSource)) {
        ENGINEERINGDataSet.CUT_PARTSDataTable c = (ENGINEERINGDataSet.CUT_PARTSDataTable)comboBox1.DataSource;
        textBox1.Text = (string)c[comboBox1.SelectedIndex][@"CNC1"];
        textBox2.Text = (string)c[comboBox1.SelectedIndex][@"CNC2"];
      }
      get_priorities();
      if (!checkBox1.Checked && comboBox1.Focused && !listBox5.Focused) {
        update_common_parts();
      }
    }

    private void comboBox1_MouseClick(object sender, MouseEventArgs e) {

    }

    private void radioSelect(object sender, MouseEventArgs e) {
      int si = (sender as ListBox).IndexFromPoint(e.Location);
      bool selected = si != -1 && (sender as ListBox).GetSelected(si);
      foreach (ListBox lb in lbs) {
        if ((sender != lb) && selected) {
          lb.SetSelected(si, false);
        }
      }
    }

    private void listBox5_SelectedIndexChanged(object sender, EventArgs e) {
      string partnum = (string)(listBox5.Items[listBox5.SelectedIndex] as DataRowView)[@"PARTNUM"];
      if (listBox5.Focused) {
        comboBox1.SelectedIndex = comboBox1.FindString(partnum);
        if (!(comboBox1.DataSource is BindingSource)) {
          ENGINEERINGDataSet.CUT_PARTSDataTable c = (ENGINEERINGDataSet.CUT_PARTSDataTable)comboBox1.DataSource;
          textBox1.Text = (string)c[comboBox1.SelectedIndex][@"CNC1"];
          textBox2.Text = (string)c[comboBox1.SelectedIndex][@"CNC2"];
        }
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {
      if (checkBox1.Checked) {
        toggle_filter(true);
      } else {
        toggle_filter(false);
      }
    }
  }
}
