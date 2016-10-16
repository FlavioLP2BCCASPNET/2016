using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.BLL
{
    public class Matriculas
    {
        public List<MODEL.Matriculas> Select()
        {
            DAL.Matriculas Matriculas = new DAL.Matriculas();

            return Matriculas.Select();
        }

        public void Insert(MODEL.Matriculas matriculas)
        {
            DAL.Matriculas Matriculas = new DAL.Matriculas();
            //
            Matriculas.Insert(matriculas);
        }

        public void Update(MODEL.Matriculas matriculas)
        {
            DAL.Matriculas Matriculas = new DAL.Matriculas();
            Matriculas.Update(matriculas);
        }

        public void Delete(MODEL.Matriculas matriculas)
        {
            DAL.Matriculas Matriculas = new DAL.Matriculas();

            Matriculas.Delete(matriculas);
        }
    }
}
