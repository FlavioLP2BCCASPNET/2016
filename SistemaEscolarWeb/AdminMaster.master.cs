﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtAcessoAdmin_Click(object sender, EventArgs e)
    {
        Session["USUARIO"] = null;
        Response.Redirect("~/Page2.aspx");
    }
}
