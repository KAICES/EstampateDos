using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Telefono
    {

        [Key]
        public int idTelefono { get; set; }

        public string Numero { get; set; }

        public int Usuario_idUsuario { get; set; }

        public virtual Usuario Usuario{ get; set; }

    }
}