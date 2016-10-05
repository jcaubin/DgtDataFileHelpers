using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleDgtData.DAL;
using System.Collections.Generic;
using System.Linq;


namespace DgtWsProxyTests.src
{
    [TestClass]
    public class DgtContextTests
    {
        [TestMethod]
        public void TestDgteContext()
        {
            using (var context = new RegistroDgtContext())
            {
                var c = context.Registros.Count();
                Assert.AreEqual(0, c);
            }
        }
    }
}
