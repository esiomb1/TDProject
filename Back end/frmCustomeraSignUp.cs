using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Back_end
{
    public partial class frmCustomeraSignUp : Form
    {
        public frmCustomeraSignUp()
        {
            InitializeComponent();
        }

        private void frmCustomerandUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["CartConnectionString"].ToString();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Customers(CustomerId, Email, CustomerName, UserId) values (@CustomerId, @Email, @CustomerName, @UserId)", con);
            cmd1.Parameters.AddWithValue("@CustomersId", txtCustomerId.Text);
            cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd1.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
            cmd1.Parameters.AddWithValue("@UserId", txtEmail.Text);
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
            SqlCommand cmd2 = new SqlCommand("Insert into Users(UserId, UserName, PasswordName) values (@UserId, @UserName, @PasswordName)", con);
            cmd2.Parameters.AddWithValue("@UserId", txtUserId.Text);
            cmd2.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd2.Parameters.AddWithValue("@PasswordName", txtPasswordName.Text);
            cmd2.ExecuteNonQuery();
            cmd2.Parameters.Clear();
            MessageBox.Show("Data inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["CartConnectionString"].ToString();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Update Customers set CustomersId=@CustomersId, Email=@Email, CustomerName=@CustomerName, UserId=@UserId where CustomersId=" + txtCustomerId.Text + "'", con);
            cmd1.Parameters.AddWithValue("@CustomersId", txtCustomerId.Text);
            cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd1.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
            cmd1.Parameters.AddWithValue("@UserId", txtUserId.Text);
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
            SqlCommand cmd2 = new SqlCommand("Update Users set UserName=@UserName, PasswordName=@PasswordName where UserName=" + txtUserName.Text + "'", con);
            cmd2.Parameters.AddWithValue("@UserId", txtUserId.Text);
            cmd2.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd2.Parameters.AddWithValue("@PasswordName", txtPasswordName.Text);
            cmd2.ExecuteNonQuery();
            cmd2.Parameters.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                            txtPasswordName.Text = dr2["PasswordName"].ToString();
                        }
                        dr2.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your Customer Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}


