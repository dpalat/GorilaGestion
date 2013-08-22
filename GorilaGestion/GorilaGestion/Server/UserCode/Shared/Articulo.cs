using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Articulo
    {
        partial void Año_Validate( EntityValidationResultsBuilder results )
        {
            if ( this.Año < 1900 || this.Año > 2200 )
                results.AddPropertyError( "El formato del año es incorrecto." );
        }

        partial void NoComerciableAPartirDe_Validate( EntityValidationResultsBuilder results )
        {
            if ( this.NoComerciableAPartirDe < DateTime.Now )
                results.AddPropertyError( "La fecha para expirar el producto debe ser mayor a la actual." );

        }

        partial void IVAVentas_Validate( EntityValidationResultsBuilder results )
        {
            if ( this.IVAVentas < 0 || this.IVAVentas > 100 )
                results.AddPropertyError("El porcentaje de IVA ventas debe estar entre 0 y 100.");
        }

        partial void IVACompras_Validate( EntityValidationResultsBuilder results )
        {
            if ( this.IVACompras < 0 || this.IVACompras > 100 )
                results.AddPropertyError( "El porcentaje de IVA compras debe estar entre 0 y 100." );
        }
    }
}
