using System;
using CurrencyCheckerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyCheckerServices;

namespace CurrencyCheckerUnitTests
{
    [TestClass]
    public class ApiDataTests
    {
        [TestMethod]
        public void TestDataGet()
        {
            StashTabSet tabSet = ApiDataProcessor.RequestSet("");
            Assert.IsNotNull(tabSet);
            Assert.IsInstanceOfType(tabSet, typeof(StashTabSet));
                
        }
    }
}
