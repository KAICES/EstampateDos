using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class TipoUsuario
    {
        [Key]
        public int idTipoUsuario { get; set; }

        public string NombreTipoUsuario { get; set; }

        public int Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}