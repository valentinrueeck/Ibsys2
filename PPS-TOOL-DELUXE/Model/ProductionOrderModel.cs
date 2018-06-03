using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS_TOOL_DELUXE.Model
{
    public class ProductionOrderModel
    {
        public List<int> Item { get; set; }
        public int SelectedItem { get; set; }
        public int Number { get; set; }

        public ProductionOrderModel(List<int> item, int selectedItem, int number)
        {
            this.Item = item;
            this.SelectedItem = selectedItem;
            this.Number = number;
        }
    }
}
