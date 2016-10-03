using Microsoft.VisualStudio.TestTools.UnitTesting;
using DgtWsProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            Assert.AreEqual(DgtResponseState.Ok, resp.State);

            File.WriteAllText(resp.FileName, resp.FileContent);
        }

        [TestMethod()]
        public void GetDgtMicrodatosTest2()
        {
            DgtService s = new DgtService();
            //DgtRequest req = new DgtRequest() { FileType = DgtSubcategory.Matriculaciones, FileDate = new DateTime(2016, 09, 05) };
            //var resp = s.GetDgtMicrodatos(req);

            //Assert.AreEqual(DgtResponseState.Ok, resp.State);

            //File.WriteAllText(resp.FileName, resp.FileContent);

            DateTime begin = new DateTime(2016, 09, 01);
            DateTime end = new DateTime(2016, 09, 30);
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                var r2 = s.GetDgtMicrodatos(new DgtRequest() { FileType = DgtSubcategory.Matriculaciones, FileDate = date });
                if (r2.State == DgtResponseState.Ok)
                {
                    File.WriteAllText(r2.FileName, r2.FileContent);
                    File.AppendAllText("septiembreDemo.txt", r2.FileContent);
                }
            }
        }

        [TestMethod()]
        public void GetDgtMicrodatosTest3()
        {
            DgtService s = new DgtService();
            //DgtRequest req = new DgtRequest() { FileType = DgtSubcategory.Matriculaciones, FileDate = new DateTime(2016, 09, 05) };
            //var resp = s.GetDgtMicrodatos(req);

            //Assert.AreEqual(DgtResponseState.Ok, resp.State);

            //File.WriteAllText(resp.FileName, resp.FileContent);

            DateTime begin = new DateTime(2016, 09, 01);
            DateTime end = new DateTime(2016, 09, 30);
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                var r2 = s.GetDgtMicrodatos(new DgtRequest() { FileType = DgtSubcategory.Bajas, FileDate = date });
                if (r2.State == DgtResponseState.Ok)
                {
                    File.WriteAllText(r2.FileName, r2.FileContent);
                    File.AppendAllText("septiembreBajasProv.txt", r2.FileContent);
                }
            }
        }
    }
}