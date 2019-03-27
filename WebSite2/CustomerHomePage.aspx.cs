using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerHomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != null)
        {

            lblUser.Text = "welcome" + Session["User"].ToString();
        }
    }

    protected void btnCheckout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Checkout.aspx");
    }
}