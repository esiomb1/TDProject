using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WomensTrousers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];
        if (dt != null)
        {

            Label5.Text = dt.Rows.Count.ToString();
        }
        else
        {
            Label5.Text = "0";
        }
    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "addtocart")
        {

            Response.Redirect("ClothingCheckout.aspx?id=" + e.CommandArgument.ToString());

        }
    }
}