using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.DAL
{
   public class Alunos
    {

        private string strCon = Conexao.getConexao();

        public List<MODEL.Alunos> Select()
        {
            List<MODEL.Alunos> lstAlunos = new List<MODEL.Alunos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Alunos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Alunos alunos = new MODEL.Alunos();
                    alunos.id = Convert.ToInt32(reader[0].ToString());
                    alunos.nome = reader["nome"].ToString();
                    alunos.endereco = reader["endereco"].ToString();
                    alunos.cidade = reader["cidade"].ToString();
                    alunos.estado = reader["estado"].ToString();
                    alunos.aniversario = Convert.ToDateTime(reader["aniversario"].ToString());
                    lstAlunos.Add(alunos);
                        

                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Clientes...");
            }

            finally
            {
                conexao.Close();    
            }
            

            return lstAlunos;


        }

        public List<MODEL.Alunos> SelectById(int id)
        {
            List<MODEL.Alunos> lstAlunos = new List<MODEL.Alunos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Alunos where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Alunos alunos = new MODEL.Alunos();
                    alunos.id = Convert.ToInt32(reader[0].ToString());
                    alunos.nome = reader["nome"].ToString();
                    alunos.endereco = reader["endereco"].ToString();
                    alunos.cidade = reader["cidade"].ToString();
                    alunos.estado = reader["estado"].ToString();
                    alunos.aniversario = Convert.ToDateTime(reader["aniversario"].ToString());
                    lstAlunos.Add(alunos);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Alunos por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstAlunos;
        }


        public List<MODEL.Alunos> SelectByNome(string nome)
        {
            List<MODEL.Alunos> lstAlunos = new List<MODEL.Alunos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Alunos where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Alunos alunos = new MODEL.Alunos();
                    alunos.id = Convert.ToInt32(reader[0].ToString());
                    alunos.nome = reader["nome"].ToString();
                    alunos.endereco = reader["endereco"].ToString();
                    alunos.cidade = reader["cidade"].ToString();
                    alunos.estado = reader["estado"].ToString();
                    alunos.aniversario = Convert.ToDateTime(reader["aniversario"].ToString());
                    lstAlunos.Add(alunos);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Alunos por Nome...");
            }
            finally
            {
                conexao.Close();
            }

            return lstAlunos;
        }

        public void Insert(MODEL.Alunos alunos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Alunos values(@nome, @endereco, @cidade, @estado, @aniversario);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            //erro
            cmd.Parameters.AddWithValue("@id", alunos.id);
            cmd.Parameters.AddWithValue("@nome", alunos.nome);
            cmd.Parameters.AddWithValue("@endereco", alunos.endereco);
            cmd.Parameters.AddWithValue("@cidade", alunos.cidade);
            cmd.Parameters.AddWithValue("@estado", alunos.estado);
            cmd.Parameters.AddWithValue("@aniversario", alunos.aniversario);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message+" - Deu erro na inserção de Alunos...");
            }
            finally
            {
                conexao.Close();
            }
        }
        
        public void Update (MODEL.Alunos alunos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            // string sql = "Insert into Alunos values(@nome, @endereco, @cidade, @estados, @aniversario);";

            string sql = "Update Alunos set nome = @nome,";
            sql += " enderecp = @endereco, cidade = @cidade, ";
            sql += "estado = @estado , aniversario =@aniversario ";
            sql += " where id=@id;";
        
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", alunos.id);
            cmd.Parameters.AddWithValue("@nome", alunos.nome);
            cmd.Parameters.AddWithValue("@endereco", alunos.endereco);
            cmd.Parameters.AddWithValue("@cidade", alunos.cidade);
            cmd.Parameters.AddWithValue("@estado", alunos.estado);
            cmd.Parameters.AddWithValue("@aniversario", alunos.aniversario);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de Alunos...");
            }
            finally
            {
                conexao.Close();
            }
                       
         }

        public void Delete(MODEL.Alunos alunos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Alunos where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", alunos.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na Remoção de Alunos...");
            }
            finally
            {
                conexao.Close();
            }


        }

    }
}
