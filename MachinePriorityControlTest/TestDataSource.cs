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
      Assert.AreEqual(cnt, 3);
    }
  }
}
