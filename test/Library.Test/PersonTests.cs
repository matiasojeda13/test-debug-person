using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person person;

        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
            var person = new Person("Matias Ojeda","4.548.798-8");
        }

        [Test]
        public void NombreNoVacio() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            string resultado = "Matias Ojeda";
            Assert.AreEqual(person.Name,resultado);
        }
        [Test]
        public void DigitoVerificadorCorrecto() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            string resultado = "4.548.798-8";
            Assert.AreEqual(person.ID,resultado);
        }
    }
}