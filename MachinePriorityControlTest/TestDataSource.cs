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
  }
}
