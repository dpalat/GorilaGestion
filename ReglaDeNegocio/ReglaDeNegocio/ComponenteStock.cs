using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReglaDeNegocio
{
    public class ComponenteStock
    {
        public int CalcularIngresoDeStock( int stockActual, int stockAAgregar )
        {
            return stockActual + stockAAgregar;
        }

        public int CalcularSalidaDeStock( int stockActual, int stockAQuitar )
        {
            return stockActual - stockAQuitar;
        }
    }
}
