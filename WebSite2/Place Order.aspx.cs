using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Place_Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("Productid");
            dt.Columns.Add("Description");
            dt.Columns.Add("Price");
            dt.Columns.Add("ProductType");
            dt.Columns.Add("ProductImage");


            if (Request.QueryString["id"] != null)
            {
                if (Session["Buyitems"] == null)
                {

                    dr = dt.NewRow();
                    String mycon = "H:\\Desktop\\Final clothing project\\App_data\\Cart.mdf";
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
                    dr["Price"] = Request.QueryString["Price"];
                    dr["ProductType"] = ds.Tables[0].Rows[0]["ProductType"].ToString();
                    dr["ProductImage"] = ds.Tables[0].Rows[0]["productimage"].ToString();
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Session["buyitems"] = dt;
                    Response.Redirect("AddToCart.aspx");

                }
                else
                {

                    dt = (DataTable)Session["buyitems"];
                    int sr;
                    sr = dt.Rows.Count;

                    dr = dt.NewRow();
                    String mycon = "H:\\Desktop\\Final clothing project\\App_data\\Cart.mdf";
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
                    dr["Price"] = Request.QueryString["Price"];
                    dr["ProductType"] = ds.Tables[0].Rows[0]["ProductType"].ToString();
                    dr["ProductImage"] = ds.Tables[0].Rows[0]["productimage"].ToString();
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    int Price = Convert.ToInt16(ds.Tables[0].Rows[0]["Price"].ToString());
                    int totalprice = Price + Price;
                    dr["totalprice"] = totalprice;
                    Session["buyitems"] = dt;
                    Response.Redirect("AddToCart.aspx");

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
            // Label2.Text = GridView1.Rows.Count.ToString();

        }
        Label8.Text = DateTime.Now.ToShortDateString();
        findorderid();
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
    public void findorderid()
    {
        String pass = "abcdefghijklmnopqrstuvwxyz123456789";
        Random r = new Random();
        char[] mypass = new char[5];
        for (int i = 0; i < 5; i++)
        {
            mypass[i] = pass[(int)(35 * r.NextDouble())];

        }
        String orderid;
        orderid = "Order" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + new string(mypass);

        Label7.Text = orderid;


    }
    public void saveaddress()
    {
        String updatepass = "insert into tblOrder(OrderNo,CustomerNo,CardNo,Address,CustoomerName,CardName,Exp year) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
        String mycon1 = "H:\\Desktop\\Final clothing project\\App_data\\Cart.mdf";
        SqlConnection s = new SqlConnection(mycon1);
        s.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = updatepass;
        cmd1.Connection = s;
        cmd1.ExecuteNonQuery();
        s.Close();
    }
protected void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        DataTable dt;
        dt = (DataTable)Session["buyitems"];
        saveaddress();
        Response.Redirect("SuccessFullOrder.aspx");
    }
}

