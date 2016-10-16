using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.DAL
{
    public class Aulas
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Aulas> Select()
        {
            List<MODEL.Aulas> lstAulas = new List<MODEL.Aulas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aulas";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Aulas aulas = new MODEL.Aulas();
                    aulas.id = Convert.ToInt32(reader[0].ToString());
                    aulas.nome = reader["nome"].ToString();
                    aulas.cursos_id = Convert.ToInt32(reader["cursos_id"].ToString());
                    aulas.cargaHoraria = Convert.ToInt32(reader["cargaHoraria"].ToString());
                    aulas.qtdAlunos = Convert.ToInt32(reader["qtdAlunos"].ToString());

                    lstAulas.Add(aulas);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Aulas...");
            }
            finally
            {
                conexao.Close();
            }

            return lstAulas;
        }



        public List<MODEL.Aulas> SelectByCurso(int cursos_id)
        {
            List<MODEL.Aulas> lstAulas = new List<MODEL.Aulas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aulas where cursos_id=@cursos_id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cursos_id", cursos_id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Aulas aulas = new MODEL.Aulas();
                    aulas.id = Convert.ToInt32(reader[0].ToString());
                    aulas.nome = reader["nome"].ToString();
                    aulas.cursos_id = Convert.ToInt32(reader["cursos_id"].ToString());
                    aulas.cargaHoraria = Convert.ToInt32(reader["cargaHoraria"].ToString());
                    aulas.qtdAlunos = Convert.ToInt32(reader["qtdAlunos"].ToString());

                    lstAulas.Add(aulas);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Aulas...");
            }
            finally
            {
                conexao.Close();
            }

            return lstAulas;
        }


        public MODEL.Aulas SelectAulaID(int idAula)
        {
            
            SqlConnection conexao = new SqlConnection(strCon);
            MODEL.Aulas aulas = new MODEL.Aulas();

            string sql = "Select * from Aulas where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idAula);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    aulas.id = Convert.ToInt32(reader[0].ToString());
                    aulas.nome = reader["nome"].ToString();
                    aulas.cursos_id = Convert.ToInt32(reader["cursos_id"].ToString());
                    aulas.cargaHoraria = Convert.ToInt32(reader["cargaHoraria"].ToString());
                    aulas.qtdAlunos = Convert.ToInt32(reader["qtdAlunos"].ToString());

                    
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Aulas...");
            }
            finally
            {
                conexao.Close();
            }

            return aulas;
        }


        public void Insert(MODEL.Aulas aulas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Aulas values (@id, @cursos_id, @nome,@cargaHoraria,@qtdAlunos);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", aulas.id);
            cmd.Parameters.AddWithValue("@cursos_id", aulas.cursos_id);
            cmd.Parameters.AddWithValue("@nome", aulas.nome);
            cmd.Parameters.AddWithValue("@cargaHoraria", aulas.cargaHoraria);
            cmd.Parameters.AddWithValue("@qtdAlunos", aulas.qtdAlunos);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Aulas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Aulas aulas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Aulas set  ";
            sql += " cursos_id=@cursos_id, nome=@nome,cargaHoraria=@cargaHoraria,qtdAlunos=@qtdAlunos where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", aulas.id);
            cmd.Parameters.AddWithValue("@cursos_id", aulas.cursos_id);
            cmd.Parameters.AddWithValue("@nome", aulas.nome);
            cmd.Parameters.AddWithValue("@cargaHoraria", aulas.cargaHoraria);
            cmd.Parameters.AddWithValue("@qtdAlunos", aulas.qtdAlunos);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Aulas");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Aulas aulas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Aulas where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", aulas.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Aulas");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
