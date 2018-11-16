using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class FacturaVenta
    {
        [Key]
        public int IdFacturaVenta { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public double ValorNeto { get; set; }
        public double ValorTotal { get; set; }
        public virtual ICollection<Envio> Envios{ get; set; }
        public virtual ICollection<FacturaVenta_has_FormasPago> FacturaVenta_Has_FormasPagos { get; set; }
        public virtual ICollection<Tarifas_has_FacturaVenta> Tarfas_HasFacturaVentas { get; set; }
        public virtual ICollection<Usuario_hasFacturaVenta> Usuario_HasFacturaVentas { get; set; }

    }
}