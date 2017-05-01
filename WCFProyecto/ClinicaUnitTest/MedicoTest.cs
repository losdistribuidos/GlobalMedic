using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClinicaUnitTest
{
    [TestClass]
    public class MedicoTest
    {
        [TestMethod]
        public void TestCrearMedico()
        {
            MedicosWS.MedicoClient proxy = new MedicosWS.MedicoClient();
            MedicosWS.Medicos medicoCreado = proxy.CrearMedico(new MedicosWS.Medicos()
            {
                Codigo = 130,
                Nombre = "Maria",
                Apellido = "Castillo",
                Direccion = "Lima",
                Telefono = "987876544",
                Email = "prueba12@gmail.com",
                Estado = "Disponible",
                Especialidad = "E12",
                Horario = "H04",
            });
            Assert.AreEqual(130, medicoCreado.Codigo);
            Assert.AreEqual("Maria", medicoCreado.Nombre);
            Assert.AreEqual("Castillo", medicoCreado.Apellido);
            Assert.AreEqual("Lima", medicoCreado.Direccion);
            Assert.AreEqual("987876544", medicoCreado.Telefono);
            Assert.AreEqual("prueba12@gmail.com", medicoCreado.Email);
            Assert.AreEqual("Disponible", medicoCreado.Estado);
            Assert.AreEqual("E12", medicoCreado.Especialidad);
            Assert.AreEqual("H04", medicoCreado.Horario);
        }
    }
}
