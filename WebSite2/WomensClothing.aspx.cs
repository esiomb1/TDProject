using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WomensClothing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnTopsandShirts_Click(object sender, EventArgs e)
    {
        Response.Redirect("WomensTopsandShirts.aspx");
    }

    protected void btnTrousers_Click(object sender, EventArgs e)
    {
        Response.Redirect("WomensTrousers.aspx");
    }

    protected void btnSwimmwear_Click(object sender, EventArgs e)
    {
        Response.Redirect("WomensSwimmwear.aspx");
    }

    protected void btnDresses_Click(object sender, EventArgs e)
    {
        Response.Redirect("WomensDresses.aspx");
    }

    protected void btnShoesandTrainers_Click(object sender, EventArgs e)
    {
        Response.Redirect("WomensShoesandTrainers.aspx");
    }

    protected void btnAcceroise_Click(object sender, EventArgs e)
    {
        Response.Redirect("WomensAcceroise.aspx");
    }

    protected void btnWomensHats_Click(object sender, EventArgs e)
    {
        Response.Redirect("WomensHats.aspx");
    }
}