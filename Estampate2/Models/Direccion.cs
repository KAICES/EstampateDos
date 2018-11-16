using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Direccion
    {
        [Key]
        public int idDireccion  { get; set; }

        public  string DireccionCorrespondencia { get; set; }

        public int Ciudad_idCiudad { get; set; }

        public virtual ICollection<Usuario> Usuarios{ get; set; }

        public virtual ICollection<Envio> Envios { get; set; }

    }
}