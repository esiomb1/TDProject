﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class MensCoatsandJackets : System.Web.UI.Page
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

    protected void btnAddToCart_Click(object sender, EventArgs e)
    {

    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "addtocart")
        {

            Response.Redirect("ClothingCheckout.aspx?id=" + e.CommandArgument.ToString());

        }
    }
}