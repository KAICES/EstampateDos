using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Usuario_has_Camiseta
    {
        [Key]
        public int idUsuario_has_Camiseta { get; set; }

        public int Usuario_idUsuario { get; set; }

        public int Camiseta_idCamiseta { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Camiseta Camiseta{ get; set; }



    }
}