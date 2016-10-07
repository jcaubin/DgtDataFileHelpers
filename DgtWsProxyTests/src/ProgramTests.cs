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
        public void LoadTestMatriculaciones()
        {
            string path;
            path = @"E:\NET\Proyectos\DgtData\septiembreMatriculacionesProv.txt";
            var r = Program.Load<MatriculacionData>(path, TipoFichero.matriculas);

            Assert.IsTrue(r > 0);
        }

        [TestMethod()]
        public void LoadTestTransfer()
        {
            string path;
            path = @"E:\NET\Proyectos\DgtData\septiembreTransferenciasProv.txt";
            var r = Program.Load<MatriculacionData>(path, TipoFichero.transferencias);

            Assert.IsTrue(r > 0);
        }

        [TestMethod()]
        public void LoadTestBajas()
        {
            string path;
            path = @"E:\NET\Proyectos\DgtData\septiembreBajasProv.txt";
            var r = Program.Load<MatriculacionData>(path, TipoFichero.bajas);

            Assert.IsTrue(r > 0);
        }

        [TestMethod()]
        public void ProcessTest()
        {
            var r = Program.Process<MatriculacionData, MatriculacionDataOut>(@"E:\NET\Proyectos\DgtData\export_mat_20160905.txt");
            Assert.IsTrue(r > 0);
        }
    }
}