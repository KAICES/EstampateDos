using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Tarifas_has_FacturaVenta
    {

        [Key]
        public int IdTarifas_has_FacturaVenta { get; set; }

        public int Tarifa_idTarifa { get; set; }

        public int FacturaVenta_idFacturaVenta { get; set; }

        public virtual FacturaVenta FacturaVenta{ get; set; }

        public virtual FormasPago FormasPago { get; set; }


    }
}