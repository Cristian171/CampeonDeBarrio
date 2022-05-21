using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasCampeonDeBarrio;

namespace testCampeonDelBarrio
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Jugador jugador = new Jugador();
            // Act
            jugador.Nombre = "Pepito";
            // Assert
            Assert.AreEqual("Pepito", jugador.Nombre);
        }

        public void TestMethod2()
        {
            // Arrange
            Jugador jugador = new Jugador();
            // Act
            jugador.Puntos = -1;
            // Assert
            Assert.AreEqual(0, jugador.Puntos);
        }
        public void TestMethod3()
        {
            // Arrange
            Jugador jugador = new Jugador();
            // Act
            jugador.Puntos = 500;
            jugador.Campañas = 2;
            // Assert
            Assert.AreEqual(250, jugador.Promedio);
        }
        public void TestMethod4()
        {
            // Arrange
            Jugador jugador = new Jugador();
            // Act
            jugador.Campañas = -2;
            // Assert
            Assert.AreEqual(0 , jugador.Campañas);
        }
        public void TestMethod5()
        {
            // Arrange
            Jugador jugador = new Jugador();
            // Act
            jugador.Puntos = 1000;
            jugador.Campañas = -4;
            // Assert
            Assert.AreEqual(0, jugador.Promedio);
        }
    }
}
