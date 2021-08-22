using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backendcrudangular.Models
{
    public class Tarjeta
    {
        
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string NumeroTarjeta { get; set; }

        [Required]
        public string FechaExpiracion { get; set; }

        [Required]
        public string CVV { get; set; }


    }
}
