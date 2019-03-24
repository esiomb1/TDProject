



using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerSignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["CartConnectionString"].ToString();
        con.Open();
        SqlCommand cmd1 = new SqlCommand("Insert into Customers(CustomerId, Email, CustomerName, UserId, Address, PostCode) values (@CustomerId, @Email, @CustomerName, @UserId, @Address, @PostCode)'", con);
        cmd1.Parameters.AddWithValue("@CustomersId", txtCustomerId.Text);
        cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
        cmd1.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
        cmd1.Parameters.AddWithValue("@UserId", txtUserId.Text);
        cmd1.Parameters.AddWithValue("@Address", txtAddress.Text);
        cmd1.Parameters.AddWithValue("@PostCode", txtPostCode.Text);
        cmd1.ExecuteNonQuery();
        cmd1.Parameters.Clear();
        SqlCommand cmd2 = new SqlCommand("Insert into Users(UserId, UserName, PasswordName) values (@UserId, @UserName, @PasswordName)'", con);
        cmd2.Parameters.AddWithValue("@UserId", txtUserId.Text);
        cmd2.Parameters.AddWithValue("@UserName", txtUserName.Text);
        cmd2.Parameters.AddWithValue("@PasswordName", txtPassword.Text);
        cmd2.ExecuteNonQuery();
        cmd2.Parameters.Clear();
      
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["CartConnectionString"].ToString();
        con.Open();
        SqlCommand cmd1 = new SqlCommand("Update Customers set CustomersId=@CustomersId, Email=@Email, CustomerName=@CustomerName, Address=@Address, PostCode=@PostCode, UserId=@UserId where CustomersId='" + txtCustomerId.Text + "'", con);
        cmd1.Parameters.AddWithValue("@CustomersId", txtCustomerId.Text);
        cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
        cmd1.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
        cmd1.Parameters.AddWithValue("@UserId", txtUserId.Text);
        cmd1.Parameters.AddWithValue("@Address", txtAddress.Text);
        cmd1.Parameters.AddWithValue("@PostCode", txtPostCode.Text);
        cmd1.ExecuteNonQuery();
        cmd1.Parameters.Clear();
        SqlCommand cmd2 = new SqlCommand("Update Users set UserName=@UserName, PasswordName=@PasswordName where UserName='" + txtUserName.Text + "'", con);
        cmd2.Parameters.AddWithValue("@UserId", txtUserId.Text);
        cmd2.Parameters.AddWithValue("@UserName", txtUserName.Text);
        cmd2.Parameters.AddWithValue("@PasswordName", txtPassword.Text);
        cmd2.ExecuteNonQuery();
        cmd2.Parameters.Clear();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (txtCustomerId.Text != "")
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["CartConnectionString"].ToString();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from Customers where CustomersId='" + txtCustomerId.Text + "'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.HasRows)
            {

                while (dr1.Read())
                {
                    txtCustomerId.Text = dr1["CustomersId"].ToString();
                    txtEmail.Text = dr1["Email"].ToString();
                    txtCustomerName.Text = dr1["CustomerName"].ToString();
                    txtUserId.Text = dr1["UserId"].ToString();
                    txtAddress.Text = dr1["Address"].ToString();
                    txtPostCode.Text = dr1["PostCode"].ToString();
                }
                dr1.Close();
                SqlCommand cmd2 = new SqlCommand("Select * from Users where  UserId='" + txtUserId.Text + "'", con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.HasRows)
                {

                    while (dr2.Read())
                    {

                        txtUserId.Text = dr2["UserId"].ToString();
                        txtUserName.Text = dr2["UserName"].ToString();
                        txtPassword.Text = dr2["PasswordName"].ToString();
                    }
                    dr2.Close();
                }
            }
        }
      
    }


}

