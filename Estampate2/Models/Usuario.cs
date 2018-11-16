using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Usuario
    {
        [Key] 
        public int idUsuario { get; set; }

        public string Nombre { get; set; }

        public string Alias { get; set; }

        public string Correo { get; set; }

        public string Password { get; set; }
              
        public int TipoUsuario_idTipoUsuario { get; set; }

        public virtual ICollection<Telefono> Telefonos { get; set; }

        public virtual ICollection<Usuario_has_Camiseta> Usuario_Has_Camisetas{ get; set; }

        public virtual ICollection<Usuario_hasFacturaVenta> Usuario_HasFacturaVentas { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }


    }
}