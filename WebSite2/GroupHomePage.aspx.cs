using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GroupHomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnJackSite_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

    protected void btnShaquileSite_Click(object sender, EventArgs e)
    {
        Response.Redirect("");
    }



    protected void btnEileensSite_Click(object sender, EventArgs e)
    {

    }


    protected void btnCassandrasSite_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default");
    }
}