using Microsoft.VisualStudio.TestTools.UnitTesting;
using DgtWsProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgtWsProxy.Tests
{
    [TestClass()]
    public class DgtServiceTests
    {
        [TestMethod()]
        public void GetDgtMicrodatosTest()
        {
            DgtService s = new DgtService();
            DgtRequest req = new DgtRequest() { FileType = DgtSubcategory.Bajas, FileDate = new DateTime(2016, 09, 25) };
            var resp = s.GetDgtMicrodatos(req);

            Assert.Inconclusive();
        }
    }
}