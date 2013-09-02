
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReglaDeNegocio.Test
{
    [TestClass]
    public class Stock
    {
        [TestMethod]
        public void agregarStock()
        {
            var componente = new ComponenteStock();
            Assert.AreEqual( 20, componente.CalcularIngresoDeStock( 10, 10 ), "El stock calculado es incorrecto." );
        }

        [TestMethod]
        public void agregarStockNegativo()
        {
            var componente = new ComponenteStock();
            Assert.AreEqual( 7, componente.CalcularIngresoDeStock( 10, -3 ), "El stock calculado es incorrecto." );
        }

        [TestMethod]
        public void QuitarStock()
        {
            var componente = new ComponenteStock();
            Assert.AreEqual( 0, componente.CalcularSalidaDeStock( 10, 10 ), "El stock calculado es incorrecto." );
        }

        [TestMethod]
        public void QuitarStockNegativo()
        {
            var componente = new ComponenteStock();
            Assert.AreEqual( 11, componente.CalcularSalidaDeStock( 10, -1 ), "El stock calculado es incorrecto." );
        }
    }
}
