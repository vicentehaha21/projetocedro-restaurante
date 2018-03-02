using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Web.Models
{
    public class Contexto: DbContext
    {
           public DbSet<Restaurante> Restaurante { get; set; }
           public DbSet<Pratos> Pratos { get; set; }
    }
}