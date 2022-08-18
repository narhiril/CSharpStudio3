using System;
using System.Collections.Generic;

namespace CSharpStudio3
{
    public class MenuItem
    {
        public bool isNew { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public decimal Price { get; private set; }

        public DateTime DateAdded { get; private set; }

        public MenuItem(string name, string description, string category, decimal price)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            isNew = true;
            DateAdded = DateTime.Now;
        }

        public void MarkAsNotNew()
        {
            this.isNew = false;
        }
    }
}
