using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Machine_Priority_Control;

namespace MachinePriorityControlTest {
  [TestClass]
  public class TestForm {
    [TestMethod]
    public void TestShowDialog() {
      MachinePriority mp = new MachinePriority();
      mp.ShowDialog();
    }

    [TestMethod]
    public void TestShowDialogWithString() {
      MachinePriority mp = new MachinePriority(@"MEFX1608-01-04");
      mp.ShowDialog();
    }

    [TestMethod]
    public void TestGetPriorityDict() {
      MachinePriority mp = new MachinePriority(@"KAB1303-01");
      mp.ShowDialog();
    }
  }
}
