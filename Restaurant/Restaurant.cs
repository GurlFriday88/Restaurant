using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        public int id;
        private string Name;
        private string MenuGroup;
        public List<MenuItem> MenuItems;
        public DateTime DateUpdated= DateTime.Today;

        
        
    }

    public class MenuItem
    {
        public int id;
        public string Name { get; set; }
        private string Category { get; set; }
        public string Description { get; set; }
        public decimal Price{ get; set; }
        public bool IsNewItem = false;
        
        
        

    }
}
