using System.Collections.Generic;
namespace Machine_Priority_Control {
    
    
    public partial class ENGINEERINGDataSet {
      partial class CUT_MACHINESDataTable {
      }
    
      partial class CUT_MACHINE_PROGRAMSDataTable {
      }

      public static Dictionary<int, int> get_priority_values_inner(int partid) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        ENGINEERINGDataSetTableAdapters.CUT_MACHINE_PROGRAMSTableAdapter ta = new ENGINEERINGDataSetTableAdapters.CUT_MACHINE_PROGRAMSTableAdapter();
        ENGINEERINGDataSetTableAdapters.CUT_MACHINESTableAdapter mta = new ENGINEERINGDataSetTableAdapters.CUT_MACHINESTableAdapter();
        ENGINEERINGDataSet.CUT_MACHINE_PROGRAMSDataTable dt1 = new ENGINEERINGDataSet.CUT_MACHINE_PROGRAMSDataTable();
        ta.FillBy(dt1, partid);
        for (int i = 0; i < dt1.Rows.Count; i++) {
          int mach = 0;
          int prio = 0;
          mach = int.Parse(dt1.Rows[i][@"MACHID"].ToString());
          prio = int.Parse(dt1.Rows[i][@"PRIORITY"].ToString());
          try {
            d.Add(mach, prio);
          } catch (System.ArgumentException) {
            // Key already exists
          }
        }
        return d;
      }
    }
}
