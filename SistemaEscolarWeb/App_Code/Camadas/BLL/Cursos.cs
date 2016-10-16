using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.BLL
{
    public class Cursos
    {
        public List<MODEL.Cursos> Select()
        {
            DAL.Cursos dalCursos = new DAL.Cursos();

            return dalCursos.Select();
        }
        public MODEL.Cursos SelectById(int id)
        {
            DAL.Cursos dalCursos = new DAL.Cursos();

            return dalCursos.SelectById(id);
        }

        public void Insert(MODEL.Cursos cusrsos)
        {
            DAL.Cursos dalCursos = new DAL.Cursos();
            //
            dalCursos.Insert(cusrsos);
        }

        public void Update(MODEL.Cursos cursos)
        {
            DAL.Cursos dalCursos = new DAL.Cursos();
            dalCursos.Update(cursos);
        }

        public void Delete(MODEL.Cursos cursos)
        {
            DAL.Cursos dalCursos = new DAL.Cursos();

            dalCursos.Delete(cursos);
        }
    }
}
