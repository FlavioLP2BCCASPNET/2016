using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AreaUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["USUARIO"] !=null)
        {
            lblSucesso.Text = "Acesso feito com Sucesso, Seja bom Vindo" +Session["USUARIO"].ToString()+"";}
        else
        {
            Response.Redirect("~/Acesse.aspx");
        }
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session["USUARIO"] = null;
        Response.Redirect("~/Page2.aspx");
    }
}