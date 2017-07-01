using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcOrderItems2.Models
{
    public class ItemList
    {
        public List<ItemsInfo> Items { get; set; }
        public ItemList()
        {
            Items = new List<ItemsInfo>();
        }
    }
}