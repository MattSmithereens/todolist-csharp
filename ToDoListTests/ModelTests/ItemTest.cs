using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void GetAll_TestsContentsOfInstancesList_Item()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            newItem.Save();

            List<Item> instances = Item.GetAll();
            Item savedItems = instances[0];

            Assert.AreEqual(newItem, savedItems);
        } 

        [TestMethod]
        public void SetDescription_SetsDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            string updatedDescription = "Do the dishes";
            newItem.SetDescription(updatedDescription);
            string result = newItem.GetDescription();
            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            string result = newItem.GetDescription();
            Assert.AreEqual(description, result);
        }

    }
}