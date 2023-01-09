using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaMVC.Models
{
    public partial class Contato
    {
     
        [Key]
        public int Id {get; set;}
        public string Nome {get; set;}
        public int Telefone {get; set;}
        public DateTime Cadastro{get; set;}
    }
}