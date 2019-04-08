using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //populate the cinema drop down
            DisplayCinema();

            }
        }

    //functionm for populating the cinema drop down list
    void DisplayCinema()
    {
        //create an instance of the cinema collection
        Class_Library.clsCinemaCollection Cinema = new Class_Library.clsCinemaCollection();
        //set the data source to the list of cinema in the collection
        ddlCinema.DataSource = Cinema.AllCinema;
        //set the name of the primary key
        ddlCinema.DataValueField = "CinemaId";
        //set the data field to display
        ddlCinema.DataTextField = "Cinema";
        //bind the data to the list
        ddlCinema.DataBind();

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

    }

    protected void ddlDate_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddlMovie_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddlCinema_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

