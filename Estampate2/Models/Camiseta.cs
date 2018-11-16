using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Camiseta
    {
        [Key]
        public int idCamiseta { get; set; }

        public string  Talla { get; set; }
        public string Color { get; set; }
        public string Estilo { get; set; }

        public virtual ICollection<Usuario_has_Camiseta> Usuario_Has_Camisetas{ get; set; }

        public virtual ICollection<Estampa> Estampas { get; set; }

    }
}