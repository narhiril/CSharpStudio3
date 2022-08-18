using System;
using System.Collections.Generic;

namespace CSharpStudio3
{
    public class Menu
    {
        public readonly DateTime DateCreated;
        public DateTime LastModified { get; private set; }
        public List<MenuItem> MenuItems { get; set; }
        private List<string> Categories { get; set; }

        public Menu()
        {
            DateCreated = DateTime.Now;
            LastModified = DateCreated;
            Categories = new List<string>();
            MenuItems = new List<MenuItem>();
        }

        public Menu(IEnumerable<MenuItem> menuItems) : this()
        {
            AddMenuItem(menuItems);
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Add(menuItem);
            if (!this.Categories.Contains(menuItem.Category))
            {
                this.Categories.Add(menuItem.Category);
            }
            this.Update();
        }

        public void AddMenuItem(IEnumerable<MenuItem> menuItems)
        {
            var listItems = menuItems.ToList();
            foreach (MenuItem item in listItems)
            {
                this.AddMenuItem(item);
            }
        }

        public void MarkAllNotNew()
        {
            foreach (MenuItem item in this.MenuItems)
            {
                item.MarkAsNotNew();
            }
        }

        private void Update()
        {
            this.LastModified = DateTime.Now;
        }
    }
}
