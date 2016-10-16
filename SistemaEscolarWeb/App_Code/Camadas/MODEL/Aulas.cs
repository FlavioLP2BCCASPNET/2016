using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.MODEL
{
   public class Aulas
    {
        public int id { get; set; }
        public int cursos_id { get; set; }
        public string nome { get; set; }
        public int cargaHoraria { get; set; }
        public int qtdAlunos { get; set; }

    }
}
