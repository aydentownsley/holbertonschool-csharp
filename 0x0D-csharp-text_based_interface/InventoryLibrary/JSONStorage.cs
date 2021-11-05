using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace InventoryLibrary
{
    /// <summary>
    /// JSONStorage Class
    /// </summary>
    public class JSONStorage
    {
        Dictionary<string, Object> objects;

        public JSONStorage()
        {
            this.objects = new Dictionary<string, Object>();
            this.Load();
        }

        /// <summary>
        /// Returns Dictionary of Objects
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Object> All()
        {
            return objects;
        }

        /// <summary>
        /// Adds obj to dictionary
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Dictionary of objects</returns>
        public Dictionary<string, object> New(object obj)
        {
            objects.Add(obj.GetType().Name.ToLower() + "." + obj.GetType().GetProperty("Id").GetValue(obj).ToString(), obj);
            this.Save();
            return objects;
        }

        /// <summary>
        /// Converts Dictionary to JSON string
        /// </summary>
        /// <param name="objs"></param>
        public void Save()
        {
            var dir = Directory.GetCurrentDirectory();
            var parent = Directory.GetParent(dir);
            string path = parent.ToString() + "\\storage\\inventory_manager.json";

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(objects, options);
            if (!File.Exists(path))
                File.CreateText(path);
            else
                File.WriteAllText(path, jsonString);
        }

        /// <summary>
        /// Loads JSON data from file
        /// </summary>
        /// <returns>dictionary form of data </returns>
        public void Load()
        {
            var dir = Directory.GetCurrentDirectory();
            var parent = Directory.GetParent(dir);
            string path = parent.ToString() + "\\storage\\inventory_manager.json";
            string jsonString;


            Dictionary<string, Type> classes = new Dictionary<string, Type>();
            classes.Add("BaseClass", typeof(BaseClass));
            classes.Add("Item", typeof(Item));
            classes.Add("User", typeof(User));
            classes.Add("Inventory", typeof(Inventory));

            if (File.Exists(path) && File.ReadAllText(path) != "")
            {
                jsonString = File.ReadAllText(path);
                objects = JsonSerializer.Deserialize<Dictionary<string, Object>>(jsonString);
            }
            else
            {
                var jsFile = File.Create(path);
                jsFile.Close();
            }
        }
    }
}
