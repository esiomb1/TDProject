using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClothingProject2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerSignUp.aspx");
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

    protected void btnWomen_Click(object sender, EventArgs e)
    {
        Response.Redirect("WomensClothing.aspx");
    }

    protected void btnMen_Click(object sender, EventArgs e)
    {
        Response.Redirect("mens-clothing.aspx");
    }

    protected void btnAboutUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("AboutUs.aspx");
    }

    protected void btnContactUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContactUs.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLogin.aspx");
    }
}
