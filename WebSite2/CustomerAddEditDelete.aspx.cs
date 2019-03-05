using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerAddEditDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Click_addcustomer(object sender, EventArgs e)
    {

        SqlDataSource1.InsertParameters["Email"].DefaultValue =
        ((TextBox)GridViewCustomer.FooterRow.FindControl("txtEmail")).Text;
        SqlDataSource1.InsertParameters["CustomerName"].DefaultValue =
    ((TextBox)GridViewCustomer.FooterRow.FindControl("txtCustomerName")).Text;
        SqlDataSource1.Insert();
    }
    protected void Click_adduser(object sender, EventArgs e)
    {

        SqlDataSource1.InsertParameters["PasswordName"].DefaultValue =
        ((TextBox)GridViewCustomer.FooterRow.FindControl("txtPasswordName")).Text;
     
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
    }
}