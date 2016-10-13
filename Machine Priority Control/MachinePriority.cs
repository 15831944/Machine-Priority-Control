using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Autodesk.AutoCAD.Runtime;
//using Autodesk.AutoCAD.DatabaseServices;
//using Autodesk.AutoCAD.Geometry;

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

    private void get_priorities() {
      listBox1.ClearSelected();
      listBox2.ClearSelected();
      listBox3.ClearSelected();

      ENGINEERINGDataSetTableAdapters.CUT_MACHINE_PROGRAMSTableAdapter ta = new ENGINEERINGDataSetTableAdapters.CUT_MACHINE_PROGRAMSTableAdapter();
      ENGINEERINGDataSet.CUT_MACHINE_PROGRAMSDataTable dt1 = new ENGINEERINGDataSet.CUT_MACHINE_PROGRAMSDataTable();
      ENGINEERINGDataSet.CUT_MACHINE_PROGRAMSDataTable dt2 = new ENGINEERINGDataSet.CUT_MACHINE_PROGRAMSDataTable();
      ENGINEERINGDataSet.CUT_MACHINE_PROGRAMSDataTable dt3 = new ENGINEERINGDataSet.CUT_MACHINE_PROGRAMSDataTable();
      ta.FillByPriority(dt1, 1);
      ta.FillByPriority(dt2, 2);
      ta.FillByPriority(dt3, 3);

      foreach (DataRow row in dt1.Rows)
        listBox1.SelectedValue = (int)row[@"MACHID"];

      foreach (DataRow row in dt2.Rows)
        listBox2.SelectedValue = (int)row[@"MACHID"];

      foreach (DataRow row in dt3.Rows)
        listBox3.SelectedValue = (int)row[@"MACHID"];
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
  }
}
