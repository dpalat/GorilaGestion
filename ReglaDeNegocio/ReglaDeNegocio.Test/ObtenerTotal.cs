using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReglaDeNegocio.Test
{
    [TestClass]
    public class FacturadorTest
    {
        [TestMethod]
        public void ObtenerTotalBasico()
        {
            var facturador = new Facturador();
            Assert.AreEqual( 14, facturador.ObtenerTotal( 10, 6, 2 ), "El total esta mal calculado." );
        }
    }
}
