using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    clsCustomer Booking = new clsCustomer();

    protected void Page_Load(object sender, EventArgs e)
    {
        //upon loading the page you need to read in the cart from the session object
        Booking = (clsCustomer)Session["MyBooking"];
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //you must also save the cart every time the unload event takes place
        Session["Booking"] = Booking;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the authentication class
        clsLogin Login = new clsLogin();
        //declare a variable to store the customer no if the user who logged in
        Int32 CustomerNo;
        //authenticate the login
       CustomerNo = Login.SignIn(txtUserName.Text, txtPassword.Text);
        //if there is a customer number returned
        if (CustomerNo != 0)
        {
            //set the CustomerNumber
            Booking.CustomerNo = CustomerNo;
            //go onto the next step
            Response.Redirect("Checkout.aspx");
        }
        else
        {
            //otherwise the login failed so report an error
            lblError.Text = "Login failed";
        }
    }
}






