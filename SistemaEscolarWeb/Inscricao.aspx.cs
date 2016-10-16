
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;



public partial class Inscricao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btCadastro_Click(object sender, EventArgs e)
    {
        if (tbUsuario.Text != "" & tbSenha.Text != "" && tbNome.Text != "" && tbEmail.Text != "" && tbCSenha.Text != "")
        {
            if (tbSenha.Text == tbCSenha.Text)
            {

                String CS = ConfigurationManager.ConnectionStrings["Banco1ConnectionString1"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("insert into Usuarios values('" + tbUsuario.Text + "','" + tbSenha.Text + "','" + tbEmail.Text + "','" + tbNome.Text + "', 'U')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lblMsg.Text = "Cadastrado com Sucesso";
                    lblMsg.ForeColor = Color.Green;
                    Response.Redirect("~/Acesse.aspx");

                }
                
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "senhas não são idênticas";
            }
        }
        else
        {
            lblMsg.ForeColor = Color.Red;
            lblMsg.Text = "É obrigatorio o preenchimento de todos os campos";

        }
    }
}