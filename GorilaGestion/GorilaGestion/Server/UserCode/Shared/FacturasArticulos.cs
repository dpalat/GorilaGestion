using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class FacturasArticulos
    {
        partial void Monto_Compute( ref decimal result )
        {
            result = ( this.Cantidad * this.Precio ) - this.MontoDescuento;
        }
    }
}
