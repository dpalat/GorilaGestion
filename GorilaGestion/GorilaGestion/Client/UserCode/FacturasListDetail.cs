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
    public partial class FacturasListDetail
    {
        partial void FacturaListAddAndEditNew_CanExecute(ref bool result)
        {
            // Write your code here.

        }


        partial void Cancelar_Execute()
        {
            this.Facturas.SelectedItem.Details.DiscardChanges();
        }

        partial void Nuevo_Execute()
        {
            this.Facturas.AddNew();
        }
    }
}
