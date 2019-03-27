using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mens_clothing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnCoatsandJackets_Click(object sender, EventArgs e)
    {
        Response.Redirect("MensCoatsandJackets.aspx");
    }

    protected void btnShirt_Click(object sender, EventArgs e)
    {
        Response.Redirect("MensShirts.aspx");
    }

    protected void btnSwimwear_Click(object sender, EventArgs e)
    {
        Response.Redirect("MensSwimmwear.aspx");
    }

    protected void btnShoesandBoots_Click(object sender, EventArgs e)
    {
        Response.Redirect("MensShoesandTrainers.aspx");
    }

    protected void btnMensTops_Click(object sender, EventArgs e)
    {

    }

    protected void btnMensHats_Click(object sender, EventArgs e)
    {
        Response.Redirect("MensHats.aspx");
    }
}