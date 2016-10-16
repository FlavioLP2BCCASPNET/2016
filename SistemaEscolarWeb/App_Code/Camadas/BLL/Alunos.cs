using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.BLL
{
    public class Alunos
    {
        public List<MODEL.Alunos> Select()
        {
            DAL.Alunos dalAlu = new DAL.Alunos();

            return dalAlu.Select();
        }

        public List<MODEL.Alunos> SelectById( int id)
        {
            DAL.Alunos dalAlu = new DAL.Alunos();

            return dalAlu.SelectById(id);
        }

        public List<MODEL.Alunos> SelectByNome(string nome)
        {
            DAL.Alunos dalAlu = new DAL.Alunos();

            return dalAlu.SelectByNome(nome);
        }

        public void Insert(MODEL.Alunos alunos)
        {
            DAL.Alunos dalAlu = new DAL.Alunos();
            dalAlu.Insert(alunos);
        }

        public void Update(MODEL.Alunos alunos )
        {
            DAL.Alunos dalAlu = new DAL.Alunos();
            dalAlu.Update(alunos);
        }

        public void Delete (MODEL.Alunos alunos)
        {
             DAL.Alunos dalAlu = new DAL.Alunos();
        dalAlu.Delete(alunos);
        }
    }
}
