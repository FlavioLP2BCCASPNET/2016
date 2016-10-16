using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.BLL
{
    public class Aulas
    {
        public List<MODEL.Aulas> Select()
        {
            DAL.Aulas dalAulas = new DAL.Aulas();

            return dalAulas.Select();
        }
        public MODEL.Aulas SelectAulaID(int id)
        {
            DAL.Aulas dalAulas = new DAL.Aulas();

            return dalAulas.SelectAulaID(id);
        }

        public List<MODEL.Aulas> SelectByCurso(int idCurso)
        {
            DAL.Aulas dalAulas = new DAL.Aulas();

            return dalAulas.SelectByCurso(idCurso);
        }

        public void Insert(MODEL.Aulas aulas)
        {
            DAL.Aulas dalAulas = new DAL.Aulas();
            //
            dalAulas.Insert(aulas);
        }

        public void Update(MODEL.Aulas aulas)
        {
            DAL.Aulas dalAulas = new DAL.Aulas();
            dalAulas.Update(aulas);
        }

        public void Delete(MODEL.Aulas aulas)
        {
            DAL.Aulas dalAulas = new DAL.Aulas();

            dalAulas.Delete(aulas);
        }
    }
}
