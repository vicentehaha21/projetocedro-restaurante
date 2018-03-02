using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    [Table("Restaurante")]
    public class Restaurante
    {
        [Key]
        public int restauranteID { get; set; }
        public string Nome { get; set; }
       // public ICollection<Pratos> Pratos { get; set; }

    }
}