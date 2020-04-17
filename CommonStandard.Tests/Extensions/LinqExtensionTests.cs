using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommonStandard.Extensions;
using System.Linq;

namespace CommonStandard.Tests.Extensions
{
    [TestClass]
    public class LinqExtensionTests
    {
        [TestMethod]
        public async Task NoneWithNull()
        {
            List<int> request = null;
            Assert.IsTrue(request.None());
        }

        [TestMethod]
        public async Task NoneWithEmptyList()
        {
            List<int> request = new List<int>();
            Assert.IsTrue(request.None());
        }

        [TestMethod]
        public async Task NoneWithPopulatedList()
        {
            List<int> request = new List<int>() { 1, };
            Assert.IsFalse(request.None());
        }

        [TestMethod]
        public async Task SplitSequentially9Ints()
        {
            List<int> request = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = request.SplitSequentially(3);

            Assert.IsTrue(result.Any());
            Assert.IsTrue(result.Count == 3);

            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(2, result[0][1]);
            Assert.AreEqual(3, result[0][2]);

            Assert.AreEqual(4, result[1][0]);
            Assert.AreEqual(5, result[1][1]);
            Assert.AreEqual(6, result[1][2]);

            Assert.AreEqual(7, result[2][0]);
            Assert.AreEqual(8, result[2][1]);
            Assert.AreEqual(9, result[2][2]);
        }

        [TestMethod]
        public async Task SplitSequentially0Ints()
        {
            List<int> request = new List<int>() { };
            var result = request.SplitSequentially(3);

            Assert.IsTrue(!result.Any());
        }

        [TestMethod]
        public async Task Last0()
        {
            List<int> request = new List<int>() { };
            var result = request.Last(3);

            Assert.IsTrue(!result.Any());
        }

        [TestMethod]
        public async Task LastNegative1()
        {
            List<int> request = new List<int>() { };
            var result = request.Last(-1);

            Assert.IsTrue(!result.Any());
        }

        [TestMethod]
        public async Task LastTakeLast3Of9()
        {
            IEnumerable<int> request = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = request.Last(3);

            Assert.IsTrue(result.Any());
            Assert.IsTrue(result.Count() == 3);

            Assert.AreEqual(7, result.ElementAt(0));
            Assert.AreEqual(8, result.ElementAt(1));
            Assert.AreEqual(9, result.ElementAt(2));
        }

        [TestMethod]
        public async Task LastTakeLast3Of3()
        {
            IEnumerable<int> request = new List<int>() { 1, 2, 3 };
            var result = request.Last(3);

            Assert.IsTrue(result.Any());
            Assert.IsTrue(result.Count() == 3);

            Assert.AreEqual(1, result.ElementAt(0));
            Assert.AreEqual(2, result.ElementAt(1));
            Assert.AreEqual(3, result.ElementAt(2));
        }

        [TestMethod]
        public async Task LastTakeLast3Of2()
        {
            IEnumerable<int> request = new List<int>() { 1, 2 };
            var result = request.Last(3);

            Assert.IsTrue(result.Any());
            Assert.IsTrue(result.Count() == 2);

            Assert.AreEqual(1, result.ElementAt(0));
            Assert.AreEqual(2, result.ElementAt(1));
        }

        [TestMethod]
        public async Task LastTakeLast3Of1()
        {
            IEnumerable<int> request = new List<int>() { 1 };
            var result = request.Last(3);

            Assert.IsTrue(result.Any());
            Assert.IsTrue(result.Count() == 1);

            Assert.AreEqual(1, result.ElementAt(0));
        }
    }
}