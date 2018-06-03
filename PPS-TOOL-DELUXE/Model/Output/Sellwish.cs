﻿using System.Xml.Serialization;

namespace PPS_TOOL_DELUXE.Model.Output
{
    public class Sellwish
    {
        [XmlAttribute]
        public int article { get; set; }
        [XmlAttribute]
        public int quantity { get; set; }

        public Sellwish(int article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }

        public Sellwish()
        {
            
        }
    }
}