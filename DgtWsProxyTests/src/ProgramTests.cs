using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleDgtData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtData.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LoadTest()
        {
            var r = Program.Load<MatriculacionData>(@"E:\NET\Proyectos\DgtData\export_mat_20160905.txt");
            Assert.IsTrue(r>0);
        }

        [TestMethod()]
        public void ProcessTest()
        {
            var r = Program.Process<MatriculacionData, MatriculacionDataOut>(@"E:\NET\Proyectos\DgtData\export_mat_20160905.txt");
            Assert.IsTrue(r > 0);
        }
    }
}