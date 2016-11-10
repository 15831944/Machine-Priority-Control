// (C) Copyright 2016 by Microsoft 
//
using System;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;

// This line is not mandatory, but improves loading performances
[assembly: CommandClass(typeof(Machine_Priority_Control.MyCommands))]

namespace Machine_Priority_Control {

  // This class is instantiated by AutoCAD for each document when
  // a command is called by the user the first time in the context
  // of a given document. In other words, non static data in this class
  // is implicitly per-document!
  public class MyCommands {
    // The CommandMethod attribute can be applied to any public  member 
    // function of any public class.
    // The function should take no arguments and return nothing.
    // If the method is an intance member then the enclosing class is 
    // intantiated for each document. If the member is a static member then
    // the enclosing class is NOT intantiated.
    //
    // NOTE: CommandMethod has overloads where you can provide helpid and
    // context menu.

    // Modal Command with localized name
    //[CommandMethod("MyGroup", "MyCommand", "MyCommandLocal", CommandFlags.Modal)]
    [CommandMethod("MachinePriority")]
    public void MachinePriority() {
      Document doc = Application.DocumentManager.MdiActiveDocument;
      System.IO.FileInfo fi = new System.IO.FileInfo(doc.Name);
      MachinePriority mp = new MachinePriority(resolve_to_part(fi));
      mp.ShowDialog();
    }

    private static string resolve_to_part(System.IO.FileInfo fi) {
      string res = string.Empty;
      System.Text.RegularExpressions.MatchCollection mc;
      System.Text.RegularExpressions.Regex rx = new System.Text.RegularExpressions.Regex(@"([0-9]+)");
      mc = rx.Matches(fi.Name);
      switch (mc.Count) {
        case 3:
          res = mc[1].Value;
          break;
        case 2:
          res = mc[0].Value;
          break;
        case 1:
          res = mc[0].Value;
          break;
        default:
          break;
      }
      return ENGINEERINGDataSet.get_part_by_prog(res);
    }

    private static ObjectId[] select_entites(Editor ed) {
      TypedValue[] vals = new TypedValue[] {
        new TypedValue((int)DxfCode.Start, "TEXT"),
        new TypedValue((int)DxfCode.LayoutName, "MODEL")
      };
      PromptSelectionResult res = ed.SelectAll(new SelectionFilter(vals));
      if (res.Status == PromptStatus.OK) {
        return res.Value.GetObjectIds();
      } else {
        return null;
      }
    }

    // Modal Command with pickfirst selection
    [CommandMethod("MyGroup", "MyPickFirst", "MyPickFirstLocal", CommandFlags.Modal | CommandFlags.UsePickSet)]
    public void MyPickFirst() // This method can have any name
    {
      PromptSelectionResult result = Application.DocumentManager.MdiActiveDocument.Editor.GetSelection();
      if (result.Status == PromptStatus.OK) {
        // There are selected entities
        // Put your command using pickfirst set code here
      } else {
        // There are no selected entities
        // Put your command code here
      }
    }

    // Application Session Command with localized name
    [CommandMethod("MyGroup", "MySessionCmd", "MySessionCmdLocal", CommandFlags.Modal | CommandFlags.Session)]
    public void MySessionCmd() // This method can have any name
    {
      // Put your command code here
    }

    // LispFunction is similar to CommandMethod but it creates a lisp 
    // callable function. Many return types are supported not just string
    // or integer.
    [LispFunction("MyLispFunction", "MyLispFunctionLocal")]
    public int MyLispFunction(ResultBuffer args) // This method can have any name
    {
      // Put your command code here

      // Return a value to the AutoCAD Lisp Interpreter
      return 1;
    }

  }

}
