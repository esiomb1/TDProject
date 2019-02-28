using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Click_adduser(object sender, EventArgs e)
    {

        SqlDataSource1.InsertParameters["Email"].DefaultValue =
        ((TextBox)GridView1.FooterRow.FindControl("txtEmail")).Text;
        SqlDataSource1.InsertParameters["CustomerName"].DefaultValue =
        ((TextBox)GridView1.FooterRow.FindControl("txtCustomerName")).Text;
        SqlDataSource1.Insert();
    }
}
