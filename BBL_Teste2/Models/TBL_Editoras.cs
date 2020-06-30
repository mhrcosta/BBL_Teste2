using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBL_Teste2.Models
{
    public class TBL_Editoras
    {
        [Key]
        public int ID_Editora { get; set; }
        public string Nome { get; set; }
        public int ID_Morada { get; set; }
        public string Descricao { get; set; }
        public string EnderecoWeb { get; set; }
    }
}
