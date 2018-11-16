using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Usuario_hasFacturaVenta
    {
        [Key]
        public int IdUsuario_hasFacturaVenta { get; set; }
        public int Usuario_idUsuario { get; set; }

        public int FacturaVenta_idFactura_Venta { get; set; }

        public virtual Usuario Usuario{ get; set; }

        public virtual FacturaVenta FacturaVenta { get; set; }

    }
}