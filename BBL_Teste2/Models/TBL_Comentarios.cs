using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBL_Teste2.Models
{
    public class TBL_Comentarios
    {
        [Key]
        public int ID_Livro { get; set; }
        public int ID_Utilizador { get; set; }
        string Comentario { get; set; }
    }
}
