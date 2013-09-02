using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class ArticulosListDetail
    {
        partial void Familias_Execute()
        {
            this.Application.ShowArticulosFamiliasListDetail();
        }

        partial void Lineas_Execute()
        {
            this.Application.ShowArticulosLineasListDetail();
        }

        partial void Tipos_Execute()
        {
            this.Application.ShowArticulosTiposListDetail();
        }

        partial void Materiales_Execute()
        {
            this.Application.ShowArticulosMaterialesListDetail();
        }

        partial void UnidadesDeMedida_Execute()
        {
            this.Application.ShowUnidadesDeMedidasListDetail();
        }

        partial void Temporadas_Execute()
        {
            this.Application.ShowTemporadasListDetail();
        }
    }
}
