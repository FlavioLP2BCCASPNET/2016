using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.BLL
{
    public class Alunos_Aulas
    {
        public List<MODEL.Alunos_Aulas> Select()
        {
            DAL.Alunos_Aulas dalAlu = new DAL.Alunos_Aulas();

            return dalAlu.Select();
        }

        public List<MODEL.Alunos_Aulas> SelectById( int idAula)
        {
            DAL.Alunos_Aulas dalAlu = new DAL.Alunos_Aulas();

            return dalAlu.SelectById(idAula);
        }

        

        public void Insert(MODEL.Alunos_Aulas aula_aluno)
        {
            DAL.Alunos_Aulas dalAlu = new DAL.Alunos_Aulas();
            dalAlu.Insert(aula_aluno);




            //Atualiza Quantidade de alunos no Curso
            BLL.Cursos bllCurso = new BLL.Cursos();
            BLL.Aulas bllAulas = new BLL.Aulas();
            MODEL.Aulas aula = bllAulas.SelectAulaID(aula_aluno.idAula);
            MODEL.Cursos  curso = bllCurso.SelectById(aula.cursos_id);
            curso.quantidade = curso.quantidade + 1;
            bllCurso.Update(curso);



        }

        public void Update(MODEL.Alunos_Aulas alunos )
        {
            DAL.Alunos_Aulas dalAlu = new DAL.Alunos_Aulas();
            dalAlu.Update(alunos);
        }

        public void Delete (MODEL.Alunos_Aulas alunos)
        {
             DAL.Alunos_Aulas dalAlu = new DAL.Alunos_Aulas();
        dalAlu.Delete(alunos);
        }
    }
}
