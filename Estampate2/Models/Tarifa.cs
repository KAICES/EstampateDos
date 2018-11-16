using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Tarifa
    {
        [Key]
        public int idTarifa { get; set; }

        public string NombreTarifa { get; set; }

        public double ValorArtista { get; set; }

        public double ValorEmpresa{ get; set; }

        public double ValorTotal { get; set; }

        public virtual ICollection<Tarifa> Tarifas { get; set; }


    }
}