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
    public void TestMEFX() {
      MachinePriority mp = new MachinePriority(@"MEFX1608-01-04");
      mp.ShowDialog();
    }

    [TestMethod]
    public void TestKAB() {
      MachinePriority mp = new MachinePriority(@"KAB1303-01");
      mp.ShowDialog();
    }


    [TestMethod]
    public void TestKOHD() {
      MachinePriority mp = new MachinePriority(@"KOHD1614-01");
      mp.ShowDialog();
    }
  }
}
