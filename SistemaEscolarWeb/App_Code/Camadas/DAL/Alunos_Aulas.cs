using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Camadas.DAL
{
   public class Alunos_Aulas
    {

        private string strCon = Conexao.getConexao();

        public List<MODEL.Alunos_Aulas> Select()
        {
            List<MODEL.Alunos_Aulas> lstAlunos = new List<MODEL.Alunos_Aulas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Alunos_Aulas";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {



                    MODEL.Alunos_Aulas alunos = new MODEL.Alunos_Aulas();
                    alunos.idAula = Convert.ToInt32(reader[0].ToString());
                    alunos.idAluno = Convert.ToInt32(reader["idAluno"].ToString());
                    alunos.mediaFinal = Convert.ToDecimal(reader["mediaFinal"].ToString());
                    alunos.dataMAtricula = Convert.ToDateTime(reader["dataMatricula"].ToString());
                    alunos.status = Convert.ToChar(reader["status"].ToString());
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

        public List<MODEL.Alunos_Aulas> SelectById(int idAula)
        {
            List<MODEL.Alunos_Aulas> lstAlunos = new List<MODEL.Alunos_Aulas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Alunos_Aulas where idAula=@idAula;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idAula", idAula);
            
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Alunos_Aulas alunos = new MODEL.Alunos_Aulas();
                    alunos.idAula = Convert.ToInt32(reader[0].ToString());
                    alunos.idAluno = Convert.ToInt32(reader["idAluno"].ToString());
                    alunos.mediaFinal = Convert.ToDecimal(reader["mediaFinal"].ToString());
                    alunos.dataMAtricula = Convert.ToDateTime(reader["dataMatricula"].ToString());
                    alunos.status = Convert.ToChar(reader["status"].ToString());
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

        
        public void Insert(MODEL.Alunos_Aulas alunos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Alunos_Aulas values(@idAula, @idAluno, @mediaFinal, @dataMatricula, @status);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            //erro
            cmd.Parameters.AddWithValue("@idAula", alunos.idAula);
            cmd.Parameters.AddWithValue("@idAluno", alunos.idAluno);
            cmd.Parameters.AddWithValue("@mediaFinal", alunos.mediaFinal);
            cmd.Parameters.AddWithValue("@dataMatricula", alunos.dataMAtricula);
            cmd.Parameters.AddWithValue("@status", alunos.status);
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
        
        public void Update (MODEL.Alunos_Aulas alunos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            // string sql = "Insert into Alunos values(@nome, @endereco, @cidade, @estados, @aniversario);";

            string sql = "Update Alunos_Aulas set mediaFinal = @mediaFinal,";
            sql += " dataMatricula = @dataMatricula, status = @status, ";
            sql += " where idAula=@idAula and idAluno=@idAluno;";
        
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idAula", alunos.idAula);
            cmd.Parameters.AddWithValue("@idAluno", alunos.idAluno);
            cmd.Parameters.AddWithValue("@mediaFinal", alunos.mediaFinal);
            cmd.Parameters.AddWithValue("@dataMatricula", alunos.dataMAtricula);
            cmd.Parameters.AddWithValue("@status", alunos.status);
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

        public void Delete(MODEL.Alunos_Aulas alunos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Alunos_Aulas where idAula=@idAula and idAluno=@idAluno";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idAula", alunos.idAula);
            cmd.Parameters.AddWithValue("@idAluno", alunos.idAluno);
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
