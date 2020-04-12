using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTesty
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void AddElementsToTheEndOfList()
        {
            List<int> list = new List<int> { 0, 1, 2, };
            list.Add(3);
            Assert.AreEqual(3, list[3]);
        }

        [TestMethod]
        public void AddElementsOnPosition()
        {
            List<int> list = new List<int>(10);
            Random rand = new Random();
            for(int i = 0; i < list.Capacity; i++)
            {
                list.Add(rand.Next(0, 21));
            }
            list.Insert(5, 100);
            Assert.AreEqual(100, list[5]);
        }

        [TestMethod]
        public void DeleteElements()
        {
            List<int> list = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };
            list.Remove(5);
            Assert.IsTrue(list.SequenceEqual(new[] { 0, 1, 2, 3, 4, 6, 7, 8, 9 }));
        }

        [TestMethod]
        public void DeleteElementsOnPosition()
        {
            List<int> list = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };
            list.RemoveAt(4);
            Assert.IsTrue(list.SequenceEqual(new[] { 0, 1, 2, 3, 5, 6, 7, 8, 9 }));
        }

        [TestMethod]
        public void LookingForElement()
        {
            List<int> list = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            Assert.IsTrue(list.Contains(3));
        }
    }
}
