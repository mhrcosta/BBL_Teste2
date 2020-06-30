using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBL_Teste2.Models
{
    public class TBL_Autores
    {
        [Key]
        public int ID_Autor { get; set; }
        public string Nome { get; set; }
        public string Biografia { get; set; }
        public DateTime DataNasc { get; set; }
        public string Nacionalidade { get; set; }

    }
}
