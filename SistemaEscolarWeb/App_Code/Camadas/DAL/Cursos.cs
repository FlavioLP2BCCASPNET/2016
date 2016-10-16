using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.DAL
{
   public class Cursos
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cursos> Select()
        {
            List<MODEL.Cursos> lstCursos = new List<MODEL.Cursos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cursos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cursos cursos = new MODEL.Cursos();
                    cursos.id = Convert.ToInt32(reader[0].ToString());
                    cursos.cursos = reader["nome_curso"].ToString();
                    cursos.modulos = reader["modulo"].ToString();
                    cursos.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    cursos.valor = Convert.ToSingle(reader["valor"].ToString());
                    lstCursos.Add(cursos);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Cursos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCursos;
        }
        public MODEL.Cursos SelectById(int id)
        {
            MODEL.Cursos cursos = new MODEL.Cursos();
            
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cursos where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    
                    cursos.id = Convert.ToInt32(reader[0].ToString());
                    cursos.cursos = reader["nome_curso"].ToString();
                    cursos.modulos = reader["modulo"].ToString();
                    cursos.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    cursos.valor = Convert.ToSingle(reader["valor"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Cursos...");
            }
            finally
            {
                conexao.Close();
            }

            return cursos;
        }

        public void Insert(MODEL.Cursos cursos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Filmes values (@cursos, @modulos, @quantidade, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cursos", cursos.cursos);
            cmd.Parameters.AddWithValue("@modulos", cursos.modulos);
            cmd.Parameters.AddWithValue("@quantidade", cursos.quantidade);
            cmd.Parameters.AddWithValue("@valor", cursos.valor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Cursos...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Cursos cursos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cursos set nome_curso=@nome_curso, ";
            sql += " modulo=@modulos, quantidade=@quantidade, ";
            sql += " valor=@valor where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cursos.id);
            cmd.Parameters.AddWithValue("@nome_curso", cursos.cursos);
            cmd.Parameters.AddWithValue("@modulos", cursos.modulos);
            cmd.Parameters.AddWithValue("@quantidade", cursos.quantidade);
            cmd.Parameters.AddWithValue("@valor", cursos.valor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Cursos");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Cursos cursos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cursos where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cursos.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Curso");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
