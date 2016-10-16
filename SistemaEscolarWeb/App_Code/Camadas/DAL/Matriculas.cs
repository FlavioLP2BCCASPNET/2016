using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.DAL
{
   public class Matriculas
    {

        private string strCon = Conexao.getConexao();

        public List<MODEL.Matriculas> Select()
        {
            List<MODEL.Matriculas> lstMatriculas = new List<MODEL.Matriculas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Escola";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Matriculas matriculas = new MODEL.Matriculas();
                    matriculas.id = Convert.ToInt32(reader[0].ToString());
                    matriculas.data = Convert.ToDateTime(reader["data"].ToString());
                    matriculas.alunos_id = Convert.ToInt32(reader["alunos_id"].ToString());

                    lstMatriculas.Add(matriculas);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Locacao...");
            }
            finally
            {
                conexao.Close();
            }

            return lstMatriculas;
        }

        public void Insert(MODEL.Matriculas matriculas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Locacao values (@data, @alunos_id);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", matriculas.data);
            cmd.Parameters.AddWithValue("@alunos_id", matriculas.alunos_id);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Matriculas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Matriculas matriculas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Matriculas set data=@data, ";
            sql += " alunos_id=@alunos_id where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", matriculas.id);
            cmd.Parameters.AddWithValue("@data", matriculas.data);
            cmd.Parameters.AddWithValue("@alunos_id", matriculas.alunos_id);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Matriculas");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Matriculas matriculas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Matriculas where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", matriculas.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Matricula");
            }
            finally
            {
                conexao.Close();
            }

        }




    }
}
