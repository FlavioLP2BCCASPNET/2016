using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.MODEL
{
    public class Alunos_Aulas
    {

        public int idAula { get; set; }
        public int idAluno { get; set; }
        public decimal mediaFinal { get; set; }
        public DateTime dataMAtricula { get; set; }
        public char status { get; set; }
        

    }
}
