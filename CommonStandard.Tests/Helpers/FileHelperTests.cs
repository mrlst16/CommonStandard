using CommonStandard.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommonStandard.Tests.Helpers
{
    [TestClass]
    public class FileHelperTests
    {
        [TestMethod]
        public async Task TryLoadEmbeddedResourceResourceFileAvailable()
        {
            string resourceName = "CommonStandard.Tests.Data.test.txt";
            bool success = FileHelper.TryLoadEmbeddedResource<FileHelperTests>(resourceName, out string res);

            Assert.IsTrue(success);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(res));
            Assert.AreEqual("test", res);
        }
    }
}
