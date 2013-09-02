using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReglaDeNegocio
{
    public class Facturador
    {
        public decimal ObtenerTotal( decimal subtotal, decimal recargo, decimal descuento )
        {
            return subtotal + recargo - descuento;
        }
    }
}
