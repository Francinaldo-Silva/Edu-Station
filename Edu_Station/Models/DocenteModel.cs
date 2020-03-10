using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edu_Station.Models
{
    public class DocenteModel
    {
        public String nome { get; set; }
        public int cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public String email { get; set; }
        public String senha { get; set; }
        public String confirmar_senha { get; set; }
    }
}
