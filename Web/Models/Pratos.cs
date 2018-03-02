using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Pratos
    {
        [Key]
        public int PratoID { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        [ForeignKey("Restaurante")]
        public int? restauranteID { get; set; }
        public virtual Restaurante Restaurante { get; set; }
    }
}