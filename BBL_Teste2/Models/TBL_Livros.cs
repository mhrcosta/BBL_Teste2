using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBL_Teste2.Models
{
    public class TBL_Livros
    {
        [Key]
        public int ID_Livro { get; set; }
        public string Titulo { get; set; }
        public int ID_Autor { get; set; }
        public string ISBN { get; set; }
        public int ID_Editora { get; set; }
        public DateTime DataEdicao { get; set; }
        public int AnoEdicao { get; set; }
        public int NumeroEdicao { get; set; }
        public string Sinopse { get; set; }
    }
}
