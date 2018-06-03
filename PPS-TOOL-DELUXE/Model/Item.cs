using System.Collections.Generic;

namespace PPS_TOOL_DELUXE.Model
{
    public class Item
    {
        public int id { get; set; }
        public int need { get; set; }
        public List<Item> item { get; set; }

        public Item(int id, int need, List<Item> item)
        {
            this.id = id;
            this.need = need;
            this.item = item;
        }
    }
}
