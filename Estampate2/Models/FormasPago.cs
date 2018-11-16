using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class FormasPago
    {
        [Key]
        public int IdFormasPago { get; set; }

        public string NombreFPago{ get; set; }

        public virtual ICollection<FacturaVenta_has_FormasPago> FacturaVenta_Has_FormasPagos{ get; set; }

    }
}