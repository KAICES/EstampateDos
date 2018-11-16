using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Transportadora
    {
        [Key]
        public int idTransportadora { get; set; }

        public string NombreTransportadora { get; set; }

        public virtual ICollection<Transportadora> Transportadoras{ get; set; }

    }
}