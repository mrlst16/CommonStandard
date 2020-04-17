using CommonStandard.Math.Trigonometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommonStandard.Tests.Math.Trigonometry
{
    [TestClass]
    public class TrigHelperTestscs
    {

        [TestMethod]
        public async Task CalculateRadiansAt0Degrees()
        {
            var result = TrigHelper.Radians(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public async Task CalculateRadiansAt45Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(45), 6);
            var expected = (float)System.Math.Round(System.Math.PI * .25, 6);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CalculateRadiansAt90Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(90), 6);
            var expected = (float)System.Math.Round(System.Math.PI * .5, 6);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public async Task CalculateRadiansAt1355Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(135), 6);
            var expected = (float)System.Math.Round(System.Math.PI * .75, 6);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CalculateRadiansAt180Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(180), 6);
            var expected = (float)System.Math.Round(System.Math.PI, 6);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public async Task CalculateRadiansAt225Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(225), 6);
            var expected = (float)System.Math.Round(System.Math.PI * 1.25, 6);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CalculateRadiansAt270Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(270), 6);
            var expected = (float)System.Math.Round(System.Math.PI * 1.5, 6);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CalculateRadiansAt315Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(315), 6);
            var expected = (float)System.Math.Round(System.Math.PI * 1.75, 6);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CalculateRadiansAt360Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(360), 6);
            var expected = 0;

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public async Task CalculateRadiansAt720Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(720), 6);
            var expected = 0;

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public async Task CalculateRadiansAt765Degrees()
        {
            var result = (float)System.Math.Round(TrigHelper.Radians(765), 6);
            var expected = (float)System.Math.Round(System.Math.PI * .25, 6);

            Assert.AreEqual(expected, result);
        }
    }
}
