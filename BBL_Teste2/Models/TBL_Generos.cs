using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBL_Teste2.Models
{
    public class TBL_Generos
    {
        [Key]
        public int ID_Genero { get; set; }
        public string Genero { get; set; }
        public string Descricao { get; set; }
    }
}
