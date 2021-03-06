﻿using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        private string _description;
        private static List<Item> _instances = new List<Item> { };

        public Item(string description)
        {
            _description = description;
        }


        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }

        public static List<Item> GetAll()
        {
            return new List<Item> { };
        }

        public void Save()
        {
            _instances.Add(this);
        }
    }
}