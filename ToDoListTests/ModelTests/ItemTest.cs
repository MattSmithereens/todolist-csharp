using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTest
    {

        [TestMethod]
        public void Save_TestItemsAreSaved_Item()
        {
            string description = "Wash the dog.";
            Item newItem = new Item(description);
            newItem.Save();

            List<Item> instances = Item.GetAll();
            Item savedItems = instances[0];

            Assert.AreEqual(newItem, savedItems);
        } 

        [TestMethod]
        public void SetDescription_SetsDescription_String()
        {
            string description = "Wash the dog.";
            Item newItem = new Item(description);
            string updatedDescription = "Walk the dishes";
            newItem.SetDescription(updatedDescription);
            string result = newItem.GetDescription();
            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "Wash the dog.";
            Item newItem = new Item(description);
            string result = newItem.GetDescription();
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetAll_ReturnsItems_ItemList()
        {
            string description01 = "Wash the dog.";
            string description02 = "Walk the dishes";
            Item newItem1 = new Item(description01);
            newItem1.Save();
            Item newItem2 = new Item(description02);
            newItem2.Save();
            List<Item> newList = new List<Item> { newItem1, newItem2 };

            List<Item> result = Item.GetAll();

            CollectionAssert.AreEqual(newList, result);

        }

    }
}