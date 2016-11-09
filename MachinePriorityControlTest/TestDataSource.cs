using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Machine_Priority_Control;



namespace MachinePriorityControlTest {
  [TestClass]
  public class TestDataSource {
    [TestMethod]
    public void TestGetRows() {
      Machine_Priority_Control.ENGINEERINGDataSetTableAdapters.CUT_MACHINE_PROGRAMSTableAdapter ta = new Machine_Priority_Control.ENGINEERINGDataSetTableAdapters.CUT_MACHINE_PROGRAMSTableAdapter();
      int cnt = ta.GetDataBy(4517).Count;
      Assert.IsTrue(cnt > 0);
    }

    [TestMethod]
    public void TestGetDict() {
      System.Collections.Generic.Dictionary<int, int> d = ENGINEERINGDataSet.get_priority_values_inner(422);
      Assert.IsTrue((d is System.Collections.Generic.Dictionary<int, int>));
    }

    [TestMethod]
    public void TestUpdatePriorityValues() {
      System.Collections.Generic.Dictionary<int, int> orig_d = ENGINEERINGDataSet.get_priority_values_inner(422);
      System.Collections.Generic.Dictionary<int, int> d = new System.Collections.Generic.Dictionary<int, int>();
      d.Add(16, 3);
      d.Add(6, 3);
      d.Add(5, 3);
      ENGINEERINGDataSet.update_priority_values(422, d);
      System.Collections.Generic.Dictionary<int, int> dd = ENGINEERINGDataSet.get_priority_values_inner(422);
      System.Collections.Generic.SortedDictionary<int, int> sorig_d = new System.Collections.Generic.SortedDictionary<int, int>(orig_d);
      System.Collections.Generic.SortedDictionary<int, int> sdd = new System.Collections.Generic.SortedDictionary<int, int>(dd);
      System.Collections.Generic.SortedDictionary<int, int> sd = new System.Collections.Generic.SortedDictionary<int, int>(d);
      Assert.IsTrue(sorig_d != sdd);
      Assert.IsTrue(sd.Equals(sdd));
    }
  }
}
