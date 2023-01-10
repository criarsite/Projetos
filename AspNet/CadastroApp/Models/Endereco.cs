using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroApp.Models
{
    public class Endereco : Entity
    {
        public  Guid FornecedorId { get; set; } //FK

        public string Logradouro {get; set;}
        public string Numero {get; set;}
        public string Complemento {get; set;}
        public string Cep {get; set;}
        public string Bairo {get; set;}
        public string Cidade {get; set;}
        public string Estado {get; set;}

          /* EF Relations */
         public Fornecedor Fornecedor {get; set;} //1:1 
        
    }
}