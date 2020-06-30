using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBL_Teste2.Models
{
    public class TBL_Moradas
    {   
        [Key]
        public int ID_Morada { get; set; }
        public string Morada { get; set; }
        public string Localidade { get; set; }
        public int CodigoPostal { get; set; }

    }
}
