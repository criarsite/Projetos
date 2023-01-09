using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AgendaMVC.Models
{
    public class ContatoMetadata
    {
        [Display(Name ="Nome Completo")]
          public string Nome {get; set;}
        public int Telefone {get; set;}
         [Display(Name ="Data do cadastro")]
        public DateTime Cadastro{get; set;}
    }

[ModelMetadataType(typeof(ContatoMetadata))]
    public partial class Contato{}
}