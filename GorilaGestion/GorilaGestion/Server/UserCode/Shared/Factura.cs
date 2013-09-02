using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using ReglaDeNegocio;
namespace LightSwitchApplication
{
    public partial class Factura
    {
        partial void Total_Compute( ref decimal result )
        {
            decimal subTotal = 0;
            foreach ( var item in this.FacturasArticulos )
            {
                subTotal = subTotal + item.Monto;
            }
            var facturador = new Facturador();
            result = facturador.ObtenerTotal( subTotal, Convert.ToDecimal( this.Recargo ), Convert.ToDecimal( this.Descuento ) );
        }
    }
}
