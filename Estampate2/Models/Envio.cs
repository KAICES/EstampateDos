using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estampate2.Models
{
    public class Envio
    {
        [Key]
        public int IdEnvio { get; set; }

        public string NumeroGuia { get; set; }

        public double ValorFlete { get; set; }

        public int FacturaVenta_idFactura_Venta { get; set; }

        public int Transportadora_idTransportadora { get; set; }

        public int Direccion_idDireccion { get; set; }

        public int Direccion_Usuario_idUsuario { get; set; }

        public int Direccion_Ciudad_idCiudad { get; set; }

        public virtual ICollection<FacturaVenta> FacturaVentas { get; set; }

        public virtual ICollection<Transportadora> Transportadoras { get; set; }

        public virtual Direccion Direccion{ get; set; }


    }
}