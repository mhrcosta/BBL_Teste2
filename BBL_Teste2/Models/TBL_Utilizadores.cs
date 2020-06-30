using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBL_Teste2.Models
{
    public class TBL_Utilizadores
    {
        [Key]
        public int ID_Utilizador { get; set; }
        public string Nome { get; set; }
        public int ID_Morada { get; set; }
        public DateTime DataNasc { get; set; }
        public int ID_Foto { get; set; }
    }
}
