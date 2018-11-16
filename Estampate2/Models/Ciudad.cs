using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Ciudad
    {

        [Key]
        public int idCiudad { get; set; }

        public string NombreCiudad { get; set; }

        public virtual ICollection<Direccion> Direcciones { get; set; }

    }
}