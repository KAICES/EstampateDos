using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class FacturaVenta_has_FormasPago
    {
        public int IdFacturaVenta_has_FormasPago { get; set; }

        public int FacturaVenta_idFactura_Venta { get; set; }

        public int FormasPago_idFormasPago { get; set; }

        public virtual FacturaVenta FacturaVenta { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}