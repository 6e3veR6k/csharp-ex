using codewars_katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace test.codewars_katas
{
    [TestFixture]
    public class Finder_Tests
    {
        [Test]
        public void MissingNumberTest()
        {
            Assert.AreEqual(6, Finder.FindDeletedNumber(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new List<int>() { 5, 7, 1, 9, 4, 8, 2, 3 }));
            Assert.AreEqual(1, Finder.FindDeletedNumber(new List<int>() { 1, 2 }, new List<int>() { 2 }));
            Assert.AreEqual(6, Finder.FindDeletedNumber(new List<int>() { 1, 2, 3, 4, 5, 6 }, new List<int>() { 5, 4, 2, 3, 1 }));
            Assert.AreEqual(10, Finder.FindDeletedNumber(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new List<int>() { 9, 4, 3, 6, 8, 2, 1, 5, 7 }));
            Assert.AreEqual(1, Finder.FindDeletedNumber(new List<int>() { 1 }, new List<int>()));
        }

        [Test]
        public void NoMissingNumberTest()
        {
            Assert.AreEqual(0, Finder.FindDeletedNumber(new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, new List<int>() { 2, 3, 6, 1, 5, 4, 7 }));
            Assert.AreEqual(0, Finder.FindDeletedNumber(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new List<int>() { 5, 7, 6, 9, 4, 8, 1, 2, 3 }));
        }

        [Test]
        public void NilTest()
        {
            Assert.AreEqual(0, Finder.FindDeletedNumber(new List<int>(), new List<int>()));
            Assert.AreEqual(0, Finder.FindDeletedNumber(new List<int>(), new List<int>() { 10 }));
        }
    }
}
