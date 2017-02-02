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
            DgtRequest req = new DgtRequest() { FileType = DgtSubcategory.Bajas, FileDate = new DateTime(2016, 7, 6) };
            var resp = s.GetDgtMicrodatos(req);

            Assert.AreEqual(DgtResponseState.Ok, resp.State);

            File.WriteAllText(resp.FileName, resp.FileContent);
        }

        [TestMethod()]
        public void GetDgtMicrodatosTestMatriculaciones2()
        {
            DgtService s = new DgtService();
            //DgtRequest req = new DgtRequest() { FileType = DgtSubcategory.Matriculaciones, FileDate = new DateTime(2016, 09, 05) };
            //var resp = s.GetDgtMicrodatos(req);

            //Assert.AreEqual(DgtResponseState.Ok, resp.State);

            //File.WriteAllText(resp.FileName, resp.FileContent);

            DateTime begin = new DateTime(2016, 12, 01);
            DateTime end = DateTime.Now ;
            string filename = string.Format("MatriculacionesProv_{0}_{1}.txt", begin.ToString("yyyyMMdd"), end.ToString("yyyyMMdd"));
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                var r2 = s.GetDgtMicrodatos(new DgtRequest() { FileType = DgtSubcategory.Matriculaciones, FileDate = date });
                if (r2.State == DgtResponseState.Ok)
                {
                    File.WriteAllText(r2.FileName, r2.FileContent, Encoding.Default);
                    File.AppendAllText(filename, r2.FileContent, Encoding.Default);
                }
            }
        }


        [TestMethod()]
        public void GetDgtMicrodatosTestBajas3()
        {
            DgtService s = new DgtService();
            //DgtRequest req = new DgtRequest() { FileType = DgtSubcategory.Matriculaciones, FileDate = new DateTime(2016, 09, 05) };
            //var resp = s.GetDgtMicrodatos(req);

            //Assert.AreEqual(DgtResponseState.Ok, resp.State);

            //File.WriteAllText(resp.FileName, resp.FileContent);

            DateTime begin = new DateTime(2016, 10, 01);
            DateTime end = new DateTime(2016, 10, 31);
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                var r2 = s.GetDgtMicrodatos(new DgtRequest() { FileType = DgtSubcategory.Bajas, FileDate = date });
                if (r2.State == DgtResponseState.Ok)
                {
                    File.WriteAllText(r2.FileName, r2.FileContent, Encoding.Default);
                    File.AppendAllText("octubreBajasProv.txt", r2.FileContent, Encoding.Default);
                }
            }
        }

        [TestMethod()]
        public void GetDgtMicrodatosTestTransferencias4()
        {
            DgtService s = new DgtService();
            DateTime begin = new DateTime(2016, 10, 01);
            DateTime end = new DateTime(2016, 10, 31);
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                var r2 = s.GetDgtMicrodatos(new DgtRequest() { FileType = DgtSubcategory.Transferencias, FileDate = date });
                if (r2.State == DgtResponseState.Ok)
                {
                    File.WriteAllText(r2.FileName, r2.FileContent, Encoding.Default);
                    File.AppendAllText("octubreTransferenciasProv.txt", r2.FileContent, Encoding.Default);
                }
            }
        }

        [TestMethod()]
        public void GetDgtMicrodatosTest5()
        {
            DgtService s = new DgtService();
            //DgtRequest req = new DgtRequest() { FileType = DgtSubcategory.Matriculaciones, FileDate = new DateTime(2016, 09, 05) };
            //var resp = s.GetDgtMicrodatos(req);

            //Assert.AreEqual(DgtResponseState.Ok, resp.State);

            //File.WriteAllText(resp.FileName, resp.FileContent);

            DateTime begin = new DateTime(2016, 10, 01);
            DateTime end = new DateTime(2016, 10, 31);
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                var r2 = s.GetDgtMicrodatos(new DgtRequest() { FileType = DgtSubcategory.Matriculaciones, FileDate = date });
                if (r2.State == DgtResponseState.Ok)
                {
                    File.WriteAllText(r2.FileName, r2.FileContent, Encoding.Default);
                    File.AppendAllText("octMatProv.txt", r2.FileContent, Encoding.Default);
                }
            }
        }
    }
}