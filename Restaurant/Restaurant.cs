using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        public int id { get; set; };
        private string Name { get; set; };
        private string MenuGroup { get; set; };
        public List<MenuItem> MenuItems { get; set; };
        public DateTime DateUpdated= DateTime.Today;

        
        
    }

    public class MenuItem
    {
        public int id { get; set; };
        public string Name { get; set; }
        private string Category { get; set; }
        public string Description { get; set; }
        public decimal Price{ get; set; }
        public bool IsNewItem = false;
        
        
        

    }
}
