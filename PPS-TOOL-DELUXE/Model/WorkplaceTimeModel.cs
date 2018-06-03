using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS_TOOL_DELUXE.Model
{
    public class WorkplaceTimeModel
    {
        public int Id { get; }
        public string Label { get; }
        public int KapaNew { get; set; }
        public int SetUpNew { get; set; }
        public int KapaOld { get; set; }
        public int SetUpOld { get; set; }
        public int Total { get; set; }
        public int Shifts { get; set; }
        public int Overtime { get; set; }

        public WorkplaceTimeModel(int id, string label, int kapaNew, int setUpNew, int kapaOld, int setUpOld, int total, int shifts, int overtime)
        {
            Id = id;
            Label = label;
            KapaNew = kapaNew;
            SetUpNew = setUpNew;
            KapaOld = kapaOld;
            SetUpOld = setUpOld;
            Total = total;
            Shifts = shifts;
            Overtime = overtime;
        }
    }
}
