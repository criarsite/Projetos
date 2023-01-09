using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgendaMVC.Models.Data
{
    public class Contexto : DbContext
    {
     public Contexto(DbContextOptions<Contexto> options) : base(options)
     {
        
     }   

     public DbSet<Contato> Contatos {get; set;}
    }
}