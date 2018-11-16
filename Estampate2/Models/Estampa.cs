using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Estampa
    {

        [Key]
        public int idEstampa { get; set; }
        public string NombreEstampa { get; set; }
        public string Descripcion { get; set; }
        public string Tamaño { get; set; }
        public double Precio { get; set; }
        public string Ubicacion { get; set; }
        public string Autor { get; set; }
        public int Rating { get; set; }
        public int Popularidad { get; set; }
        public int Camiseta_idCamiseta { get; set; }
        public virtual Camiseta Camiseta { get; set; }

    }
}