using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
namespace ClinicaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProxyCitasService.CitasServiceClient swCitas = new ProxyCitasService.CitasServiceClient();
            DataSet ds = new DataSet();
            ds = swCitas.ObtenerCitaPorPacientes("48007604");
            Assert.IsNotNull(ds);
        }
    }
}
