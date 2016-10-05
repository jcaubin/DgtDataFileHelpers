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
            Program.Load<MatriculacionData>(@"E:\NET\Proyectos\DgtData\export_mensual_mat_201607.txt");
            Assert.Inconclusive();
        }
    }
}