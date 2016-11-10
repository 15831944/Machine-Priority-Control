using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Machine_Priority_Control;

namespace MachinePriorityControlTest {
  [TestClass]
  public class TestForm {
    //[TestMethod]
    //public void TestShowDialog() {
    //  MachinePriority mp = new MachinePriority();
    //  mp.ShowDialog();
    //}

    //[TestMethod]
    //public void TestShowDialogWithString() {
    //  MachinePriority mp = new MachinePriority(@"GAFX1402-08-03-01");
    //  mp.ShowDialog();
    //}

    [TestMethod]
    public void TestGetPriorityDict() {
      MachinePriority mp = new MachinePriority(@"Z75295");
      mp.ShowDialog();
    }
  }
}
