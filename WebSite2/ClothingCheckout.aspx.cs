﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ClothingCheckout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("ProductId");
            dt.Columns.Add("Description");
            dt.Columns.Add("Price");
            dt.Columns.Add("ProductImage");
            dt.Columns.Add("ProductType");
            dt.Columns.Add("Cost");
            dt.Columns.Add("TotalCost");

            if (Request.QueryString["id"] != null)
            {
                if (Session["Buyitems"] == null)
                {

                    dr = dt.NewRow();
                    String mycon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\Desktop\\Clothing website 2\\App_data\\Cart.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection scon = new SqlConnection(mycon);
                    String myquery = "select * from Product where Productid=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dr["Productid"] = ds.Tables[0].Rows[0]["Productid"].ToString();
                    dr["Description"] = ds.Tables[0].Rows[0]["Description"].ToString();
                    dr["Price"] = ds.Tables[0].Rows[0]["ProductType"].ToString();
                    dr["ProductImage"] = ds.Tables[0].Rows[0]["ProductImage"].ToString();
                    dr["ProductType"] = ds.Tables[0].Rows[0]["ProductType"].ToString();
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Session["buyitems"] = dt;
                }
                else
                {

                    dt = (DataTable)Session["buyitems"];
                    int sr;
                    sr = dt.Rows.Count;

                    dr = dt.NewRow();
                    String mycon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\Desktop\\Clothing website 2\\App_data\\Cart.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection scon = new SqlConnection(mycon);
                    String myquery = "select * from Product where Productid=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dr["Productid"] = ds.Tables[0].Rows[0]["Productid"].ToString();
                    dr["Description"] = ds.Tables[0].Rows[0]["Description"].ToString();
                    dr["Price"] = ds.Tables[0].Rows[0]["Price"].ToString();                 
                    dr["ProductImage"] = ds.Tables[0].Rows[0]["ProductImage"].ToString();
                    dr["ProductType"] = ds.Tables[0].Rows[0]["ProductType"].ToString();
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Session["buyitems"] = dt;

                }
            }
            else
            {
                dt = (DataTable)Session["buyitems"];
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (GridView1.Rows.Count > 0)
                {
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                    GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();

                }


            }
            Label1.Text = GridView1.Rows.Count.ToString();

        }

    }
    public int grandtotal()
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];
        int nrow = dt.Rows.Count;
        int i = 0;
        int gtotal = 0;
        while (i < nrow)
        {
            gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());

            i = i + 1;
        }
        return gtotal;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];


        for (int i = 0; i <= dt.Rows.Count - 1; i++)
        {
            int sr;
            int sr1;
            string qdata;
            string dtdata;
            sr = Convert.ToInt32(dt.Rows[i]["Productid"].ToString());
            TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
            qdata = cell.Text;
            dtdata = sr.ToString();
            sr1 = Convert.ToInt32(qdata);

            if (sr == sr1)
            {
                dt.Rows[i].Delete();
                dt.AcceptChanges();
                //Label1.Text = "Item Has Been Deleted From Shopping Cart";
                break;

            }
        }

        for (int i = 1; i <= dt.Rows.Count; i++)
        {
            dt.Rows[i - 1]["sno"] = i;
            dt.AcceptChanges();
        }

        Session["buyitems"] = dt;
        Response.Redirect("AddToCart.aspx");
    }
}
   