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
    public MachinePriority() {
      InitializeComponent();
    }

    public MachinePriority(string pre_selected_part) {
      PreSelectedPart = pre_selected_part;
      InitializeComponent();
      cUTPARTSBindingSource.Filter = string.Format(@"PARTNUM LIKE '{0}%'", pre_selected_part);
    }

    private void Form1_Load(object sender, EventArgs e) {
      // TODO: This line of code loads data into the 'eNGINEERINGDataSet.CUT_MACHINE_PROGRAMS' table. You can move, or remove it, as needed.
      //this.cUT_MACHINE_PROGRAMSTableAdapter.Fill(this.eNGINEERINGDataSet.CUT_MACHINE_PROGRAMS);
      this.cUT_PARTSTableAdapter.Fill(this.eNGINEERINGDataSet.CUT_PARTS);
      this.cUT_MACHINESTableAdapter.Fill(this.eNGINEERINGDataSet.CUT_MACHINES);
      Show();
      get_priorities();
      Size = Properties.Settings.Default.FormSize;
      Location = Properties.Settings.Default.FormLocation;
      update_common_parts();
      listBox5.Focus();
    }

    public Dictionary<int, int> get_priority_values() {
      int p = 0;

      if (comboBox1.SelectedValue != null &&
        int.TryParse(comboBox1.SelectedValue.ToString(), out p)) {
        return ENGINEERINGDataSet.get_priority_values_inner(p);
      } else {
        return new Dictionary<int, int>();
      }
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

    private void buttonOK_Click(object sender, EventArgs e) {
      DataRowView comboboxitem = (DataRowView)comboBox1.SelectedItem;
      ENGINEERINGDataSet.update_priority_values((int)comboboxitem[0], get_listbox_states());
      Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e) {
      Close();
    }

    private void MachinePriority_FormClosing(object sender, FormClosingEventArgs e) {
      Properties.Settings.Default.FormSize = Size;
      Properties.Settings.Default.FormLocation = Location;
      Properties.Settings.Default.Save();
    }

    public string PreSelectedPart { get; set; }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      get_priorities();
      if (comboBox1.Focused && !listBox5.Focused) {
        update_common_parts();
      }
    }

    private void update_common_parts() {
      System.Text.RegularExpressions.MatchCollection cnc1;
      System.Text.RegularExpressions.MatchCollection cnc2;
      System.Text.RegularExpressions.Regex rx = new System.Text.RegularExpressions.Regex(@"^([0-9]+)");
      if (comboBox1.SelectedItem != null) {
        cnc1 = rx.Matches((comboBox1.SelectedItem as DataRowView)[@"CNC1"].ToString());
        cnc2 = rx.Matches((comboBox1.SelectedItem as DataRowView)[@"CNC2"].ToString());
        string cnc1string = string.Empty;
        string cnc2string = string.Empty;
        if (cnc1.Count > 0) {
          cnc1string = cnc1[0].Value + '%';
        }

        if (cnc2.Count > 0) {
          cnc2string = cnc2[0].Value + '%';
        }
        listBox5.DataSource = cUT_PARTSTableAdapter.GetDataByCNCProg(cnc1string, cnc2string);
      }
    }
        
    private void listBox1_MouseClick(object sender, MouseEventArgs e) {
      int si = listBox1.IndexFromPoint(e.Location);
      bool selected = si != -1 && listBox1.GetSelected(si);
      if (selected) {
        listBox2.SetSelected(si, false);
        listBox3.SetSelected(si, false);
      }
    }

    private void listBox2_MouseClick(object sender, MouseEventArgs e) {
      int si = listBox2.IndexFromPoint(e.Location);
      bool selected = si != -1 && listBox2.GetSelected(si);
      if (selected) {
        listBox1.SetSelected(si, false);
        listBox3.SetSelected(si, false);
      }
    }

    private void listBox3_MouseClick(object sender, MouseEventArgs e) {
      int si = listBox3.IndexFromPoint(e.Location);
      bool selected = si != -1 && listBox3.GetSelected(si);
      if (selected) {
        listBox1.SetSelected(si, false);
        listBox2.SetSelected(si, false);
      }
    }

    private void listBox5_MouseClick(object sender, MouseEventArgs e) {
      int selected_idx = listBox5.IndexFromPoint(e.Location);
      if (selected_idx > -1) {
        string partnum = (string)(listBox5.Items[selected_idx] as DataRowView)[@"PARTNUM"];
        comboBox1.SelectedIndex = comboBox1.FindString(partnum);
      }
    }

    private void listBox5_SelectedIndexChanged(object sender, EventArgs e) {
      string partnum = (string)(listBox5.Items[listBox5.SelectedIndex] as DataRowView)[@"PARTNUM"];
      if (listBox5.Focused) {
        comboBox1.SelectedIndex = comboBox1.FindString(partnum); 
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {
      if (checkBox1.Checked) {
        cUTPARTSBindingSource.Filter = string.Format("PARTNUM LIKE '{0}%'", PreSelectedPart);
      } else {
        cUTPARTSBindingSource.Filter = string.Empty;
      }
    }
  }
}
