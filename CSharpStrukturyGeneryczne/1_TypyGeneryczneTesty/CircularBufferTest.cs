using System;
using _1_TypyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_TypyGeneryczneTesty
{
    [TestClass]
    public class CircularBufferTest
    {
        [TestMethod]
        public void IsEmpty()
        {
            var buffer = new CircularBuffer<double>();
            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void IsFull()
        {
            Random rand = new Random();
            var buffer = new CircularBuffer<double>(rand.Next(1, 21));
            for (int i = 0; i < buffer.BufferSize; i++)
                buffer.Add(i);
            Assert.IsTrue(buffer.IsFull);
        }

        [TestMethod]
        public void Fifo()
        {
            Random rand = new Random();
            int size = rand.Next(1, 21);
            double[] testValues = new double[size];
            var buffer = new CircularBuffer<double>(size);
            for(int i = 0; i < size; i++)
            {
                testValues[i] = rand.Next(0, 101) * rand.NextDouble();
                buffer.Add(testValues[i]);
            }
            for(int i = 0; i < size; i++)
            {
                Assert.AreEqual(testValues[i], buffer.Get());
            }
        }

        [TestMethod]
        public void Overwriting()
        {
            Random rand = new Random();
            int size = rand.Next(1, 11);
            double[] testValues = new double[2 * size];
            var buffer = new CircularBuffer<double>(size);
            for (int i = 0; i < 2*size; i++)
            {
                testValues[i] = rand.Next(0, 101) * rand.NextDouble();
                buffer.Add(testValues[i]);
            }
            Assert.IsTrue(buffer.IsFull);
            for (int i = 0; i < size; i++)
            {
                Assert.AreEqual(testValues[i+size], buffer.Get());
            }
            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void FullAndEmpty()
        {
            var buffer = new CircularBuffer<double>(3);
            Assert.IsTrue(buffer.IsEmpty);
            Assert.IsFalse(buffer.IsFull);
            buffer.Add(1);
            Assert.IsFalse(buffer.IsEmpty);
            Assert.IsFalse(buffer.IsFull);
            buffer.Add(1);
            Assert.IsFalse(buffer.IsEmpty);
            Assert.IsFalse(buffer.IsFull);
            buffer.Add(1);
            Assert.IsTrue(buffer.IsFull);
            Assert.IsFalse(buffer.IsEmpty);
            buffer.Add(1);
            Assert.IsTrue(buffer.IsFull);
            Assert.IsFalse(buffer.IsEmpty);
            buffer.Get();
            Assert.IsFalse(buffer.IsEmpty);
            Assert.IsFalse(buffer.IsFull);
            buffer.Get();
            Assert.IsFalse(buffer.IsEmpty);
            Assert.IsFalse(buffer.IsFull);
            buffer.Get();
            Assert.IsTrue(buffer.IsEmpty);
            Assert.IsFalse(buffer.IsFull);
            buffer.Get();
            Assert.IsTrue(buffer.IsEmpty);
            Assert.IsFalse(buffer.IsFull);


        }
    }
}
