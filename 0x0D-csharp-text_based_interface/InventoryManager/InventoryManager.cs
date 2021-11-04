using System;
using System.Collections.Generic;
using InventoryLibrary;
using System.Reflection;

namespace InventoryManager
{
    class InventoryManager
    {
        static void Main(string[] args)
        {
            List<object> inherited = new List<object>();
            BaseClass b = new BaseClass();
            Item i = new Item("Book");
            User u = new User("Rick Castle");
            Inventory inv = new Inventory(u.Id, i.Id, 2);
            inherited.Add(b);
            inherited.Add(u);
            inherited.Add(i);
            inherited.Add(inv);

            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            foreach (object o in inherited)
            {
                Console.WriteLine(o.ToString());
                Console.WriteLine(new string('-', 30));
                Type type = o.GetType();
                IList<PropertyInfo> props = new List<PropertyInfo>(type.GetProperties());
                foreach (PropertyInfo prop in props)
                {
                    object propValue = prop.GetValue(o, null);
                    if (propValue == null)
                        Console.WriteLine(prop);
                    else
                        Console.WriteLine(propValue.ToString());
                }
                Console.WriteLine(new string('-', 30));
            }
            

        }
    }
}
