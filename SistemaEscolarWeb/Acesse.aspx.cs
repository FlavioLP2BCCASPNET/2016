using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class Acesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Request.Cookies["UNOME"]!=null && Request.Cookies["SEN"]!=null)
            {
                TextBox1.Text = Request.Cookies["UNOME"].Value;
                Senha.Attributes["Value"] = Request.Cookies["SEN"].Value;
                CheckBox1.Checked=true;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        String CS = ConfigurationManager.ConnectionStrings["Banco1ConnectionString1"].ConnectionString;
        using (SqlConnection con = new SqlConnection(CS))
        {

            SqlCommand cmd = new SqlCommand("select * from Usuarios where Usuario ='"+ TextBox1.Text + "' and Senha='" + Senha.Text + "'", con);            
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                if (CheckBox1.Checked)
                {
                    Response.Cookies["UNOME"].Value = TextBox1.Text;
                    Response.Cookies["SEN"].Value = Senha.Text;

                    Response.Cookies["UNOME"].Expires = DateTime.Now.AddDays(15);
                    Response.Cookies["SEN"].Expires = DateTime.Now.AddDays(15);


                 
                }
                else
                {
                    Response.Cookies["UNOME"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["SEN"].Expires = DateTime.Now.AddDays(-1);
                }
                string Utipo;
                Utipo = dt.Rows[0][5].ToString().Trim();
                if (Utipo == "U") {
                    Session["USUARIO"] = TextBox1.Text;
                    Response.Redirect("~/AreaUsuario.aspx");
                }
                if (Utipo == "A")
                {
                    Session["USUARIO"] = TextBox1.Text;
                    Response.Redirect("~/AdminHome.aspx");
                }


            }

            else
            {
                lblErro.Text = "Nome ou Senha Incorreta";
            }
        }
    }
} 