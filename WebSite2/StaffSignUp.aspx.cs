using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class StaffSignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["CartConnectionString"].ToString();
        con.Open();
        SqlCommand cmd1 = new SqlCommand("Insert into Staff(StaffsId, StaffName, UserId) values (@StaffsId, @StaffName, @UserId)'", con);
        cmd1.Parameters.AddWithValue("@StaffsId", txtStaffId.Text);
        cmd1.Parameters.AddWithValue("@StaffName", txtStaffName.Text);
        cmd1.Parameters.AddWithValue("@UserId", txtUserId.Text);
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
        SqlCommand cmd1 = new SqlCommand("Update Staff set StaffsId=@StaffsId, StaffName=@StaffName, UserId=@UserId where StaffsId='" + txtStaffId.Text + "'", con);
        cmd1.Parameters.AddWithValue("@StaffsId", txtStaffId.Text);
        cmd1.Parameters.AddWithValue("@StaffName", txtStaffName.Text);
        cmd1.Parameters.AddWithValue("@UserId", txtUserId.Text);
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
        if (txtStaffId.Text != "")
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["CartConnectionString"].ToString();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from Staff where StaffsId='" + txtStaffId.Text + "'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.HasRows)
            {

                while (dr1.Read())
                {
                    txtStaffId.Text = dr1["StaffsId"].ToString();
                    txtStaffName.Text = dr1["StaffName"].ToString();
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
                        txtPassword.Text = dr2["PasswordName"].ToString();
                    }
                    dr2.Close();
                }
            }
        }

    }
}
