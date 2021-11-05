﻿using System;
using System.Collections.Generic;
using InventoryLibrary;
using System.IO;
using System.Reflection;
using InventoryManager;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryManager
{
    class InventoryManager
    {
        public static Dictionary<string, Type> types = new Dictionary<string, Type>()
        {
            {"item", typeof(Item) },
            {"user", typeof(User) },
            {"inventory", typeof(Inventory) },
            {"baseclass", typeof(BaseClass) }
        };
        static void typewrite(string dialouge, int speed)
        {
            foreach (char c in dialouge)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

        static void intro()
        {
            Console.Clear();
            List<string> lines = new List<string>();
            lines.Add("Hi There!");
            lines.Add("Welcome to The DigiStore!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (string line in lines)
            {
                typewrite(line, 25);
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(@"Inventory Manager
--------------------------
< ClassNames > show all ClassNames of objects
< All > show all objects
< All[ClassName] > show all objects of a ClassName
< Create[ClassName] > a new object
< Show[ClassName object_id] > an object
< Update[ClassName object_id] > an object
< Delete[ClassName object_id] > an object
< Exit > ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            intro();
            JSONStorage j = new JSONStorage();
            j.Load();
            string trim;
            string[] input;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("---> ");
                Console.ResetColor();
                trim = Console.ReadLine().Trim(' ');
                input = trim.Split(' ');

                
                switch(input[0].ToLower())
                {
                    case "create":
                        Create(input, j);
                        break;
                    case "all":
                        All(input, j);
                        break;
                    case "classnames":
                        CNames(input, j);
                        break;
                    case "show":
                        Show(input, j);
                        break;
                    case "update":
                        Update(input, j);
                        break;
                    case "delete":
                        Delete(input, j);
                        break;
                    case "exit":
                        Exit(input, j);
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }

        static void Create(string[] input, JSONStorage j)
        {
            if (input.Length <= 1)
            {
                Console.WriteLine("Please include Class Type when creating...");
                return;
            }

            switch (input[1].ToLower())
            {
                case "baseclass":
                    BaseClass bc = new BaseClass();
                    j.New(bc);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(bc.Id);
                    Console.ResetColor();
                    break;
                case "item":
                    if (input.Length <= 2)
                        Console.WriteLine("Item needs a name...");
                    else
                    {
                        Item i = new Item(input[2]);
                        j.New(i);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(i.Id);
                        Console.ResetColor();
                    }
                    break;
                case "user":
                    if (input.Length <= 2)
                        Console.WriteLine("User needs a name...");
                    else
                    {
                        User u = new User(input[2]);
                        j.New(u);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(u.Id);
                        Console.ResetColor();
                    }
                    break;
                case "inventory":
                    if (input.Length < 2)
                        Console.WriteLine("Too few arguments...");
                    else
                    {
                        Console.WriteLine("Input a User_id: ");
                        string uid = Console.ReadLine();
                        Console.WriteLine("Input a Item_id: ");
                        string iid = Console.ReadLine();
                        Console.WriteLine("Input a Quantity");
                        string q = Console.ReadLine();
                        int qu = int.Parse(q);
                        Inventory inv = new Inventory(uid, iid, qu);
                        j.New(inv);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(inv.Id);
                        Console.ResetColor();
                    }
                    break;
            }
            j.Save();
        }

        static void All(string[] input, JSONStorage j)
        {
            if (input.Length <= 1)
            {
                foreach (var item in j.All())
                    Console.WriteLine(item);
            }
            else if (input.Length == 2)
            {
                foreach (var item in j.All())
                {
                    if (item.Key.Split('.')[0].ToLower() == input[1].ToLower())
                            Console.WriteLine(item);
                }    
            }    
        }

        static void CNames(string[] input, JSONStorage j)
        {
            if (input.Length == 1)
            {
                foreach (var item in j.All())
                {
                    Console.WriteLine(item.Key.Split('.')[0]);
                }    
            }    
        }

        static void Show(string[] input, JSONStorage j)
        {
            if (input.Length == 3)
            {
                foreach (var item in j.All())
                {
                    if (item.Key.Split('.')[0].ToLower() == input[1].ToLower() && item.Key.Split('.')[1] == input[2])
                        Console.WriteLine(item);
                }    
            }
        }

        static void Update(string[] input, JSONStorage j)
        {
            if (input.Length == 4)
            {
                string oid = input[1] + "." + input[2];
                if (j.All().ContainsKey(oid))
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false,
                        IgnoreNullValues = true,
                    };
                    object update;
                    switch (input[1])
                    {
                        case "item":
                            update = JsonSerializer.Deserialize<Item>(j.All()[oid].ToString(), options);
                            break;
                        case "user":
                            update = JsonSerializer.Deserialize<User>(j.All()[oid].ToString(), options);
                            break;
                        case "inventory":
                            update = JsonSerializer.Deserialize<Inventory>(j.All()[oid].ToString(), options);
                            break;
                        case "baseclass":
                            update = JsonSerializer.Deserialize<BaseClass>(j.All()[oid].ToString(), options);
                            break;
                        default:
                            update = JsonSerializer.Deserialize<BaseClass>(j.All()[oid].ToString(), options);
                            break;
                    }
                    j.All().Remove(oid);
                    
                    foreach (PropertyInfo prop in update.GetType().GetProperties())
                    {
                        if (prop.Name == "Name" && input[3] == "name")
                        {
                            Console.WriteLine("Input new Name: ");
                            string name = Console.ReadLine();
                            prop.SetValue(update, name.Trim(' '));
                            continue;
                        }

                        if (prop.Name == "Date_updated")
                        { 
                            prop.SetValue(update, DateTime.Now);
                            continue;
                        }
                        if (prop.Name == "Id" && input[3].ToLower() == "id")
                        {
                            Console.Write("Input new ID: ");
                            string nid = Console.ReadLine();
                            prop.SetValue(update, nid.Trim(' '));
                            continue;
                        }
                        if (prop.Name == "Tags" && input[3].ToLower() == "tags")
                        {
                            Console.WriteLine("Not Implemented yet.");
                        }
                        if (prop.Name == "Price" && input[3].ToLower() == "price")
                        {
                            Console.WriteLine("Input new Price: ");
                            string np = Console.ReadLine();
                            float pr = float.Parse(np);
                            prop.SetValue(update, pr);
                        }
                        if (prop.Name == "Description" && input[3].ToLower() == "description")
                        {
                            Console.WriteLine("Input new desciption: ");
                            string nd = Console.ReadLine();
                            prop.SetValue(update, nd.Trim(' '));
                        }
                        if (prop.Name == "User_id" && input[3].ToLower() == "user_id")
                        {
                            Console.WriteLine("Input new User_id: ");
                            string uid = Console.ReadLine();
                            prop.SetValue(update, uid.Trim(' '));
                        }
                        if (prop.Name == "Item_id" && input[3].ToLower() == "item_id")
                        {
                            Console.WriteLine("Input new Item_id: ");
                            string iid = Console.ReadLine();
                            prop.SetValue(update, iid.Trim(' '));
                        }
                        if (prop.Name == "Quantity" && input[3].ToLower() == "quantity")
                        {
                            Console.WriteLine("Input new Quantity: ");
                            string q = Console.ReadLine();
                            prop.SetValue(update, q.Trim(' '));
                        }
                    }
                    j.New(update);
                    j.Save();
                    j.Load();
                }
            }
            else
                Console.WriteLine("Too few arguments...");
        }

        static void Delete(string[] input, JSONStorage j)
        {
            string oid = input[1] + "." + input[2];
            Console.WriteLine(oid);
            if (j.All().ContainsKey(oid.ToLower()))
            {
                j.All().Remove(oid);
                j.Save();
                Console.WriteLine("Delete Succesful");
            }
            else
                Console.WriteLine("Object Not Found...");
        }

        static void Exit(string[] input, JSONStorage j)
        {
            Environment.Exit(1);
        }
    }
}
