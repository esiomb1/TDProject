using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\Desktop\\Clothing website 2\\App_data\\Cart.mdf;Integrated Security=True;Connect Timeout=30");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != null)
        {
            Response.Redirect("~/CustomerHomePage.aspx");

        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string check = "select count (*) from [Users] where UserName = '" + txtUserName.Text + "' and PasswordName ='" + txtPassword.Text + "' ";
        SqlCommand com = new SqlCommand(check, con);
        con.Open();
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        string output = com.ExecuteScalar().ToString();
        con.Close();
        if (temp == 1)
        {
            Response.Redirect("CustomerHomePage.aspx");

        }
        else
        {
            Label1.Text = "Your UserName or password is invalid";

        }
        if (output == "1")
        {

            Session["User"] = txtUserName.Text;
            Response.Redirect("~/CustomerHomePage.aspx");
        }
        else
        {
            Label2.Text = "Login Failed";

        }


    }
}