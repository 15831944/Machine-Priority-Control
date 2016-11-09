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
    }

    private void Form1_Load(object sender, EventArgs e) {
      this.cUT_PARTSTableAdapter.Fill(this.eNGINEERINGDataSet.CUT_PARTS);
      this.cUT_MACHINESTableAdapter.Fill(this.eNGINEERINGDataSet.CUT_MACHINES);
      if (PreSelectedPart != null) {
        comboBox1.SelectedIndex = comboBox1.FindString(PreSelectedPart);
      }
      comboBox1.SelectionStart = 0;
      comboBox1.SelectionLength = 0;

      get_priorities();
      Size = Properties.Settings.Default.FormSize;
      Location = Properties.Settings.Default.FormLocation;
    }

    public Dictionary<int, int> get_priority_values() {
      int p = 0;

      if (int.TryParse(comboBox1.SelectedValue.ToString(), out p)) {
        return ENGINEERINGDataSet.get_priority_values_inner(p);
      } else {
        return new Dictionary<int, int>();
      }
    }

    private void get_priorities() {
      listBox1.ClearSelected();
      listBox2.ClearSelected();
      listBox3.ClearSelected();
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
          default:
            break;
        }
      }
    }

    public string get_name_of_machine(int machid) {
      string res = string.Empty;
      try {
        res = cUT_MACHINESTableAdapter.GetMachnameByID(machid);
      } catch (NullReferenceException) {
        //
      }
      return res;
    }

    private void buttonOK_Click(object sender, EventArgs e) {
      Console.WriteLine(@"We don't do anything yet.");
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
    }

    private void testbutton1_Click(object sender, EventArgs e) {
      System.Windows.Forms.MessageBox.Show(get_priority_values().ToString());
    }
  }
}
