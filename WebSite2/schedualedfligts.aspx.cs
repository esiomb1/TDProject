using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class schedualedfligts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayFlights();
        }
    }

    protected void lstsch_SelectedIndexChanged(object sender, EventArgs e)
    {
  
    }
    void DisplayFlights()
    {
        //create an instance for the flight collection class 
     clsFlightsCollection Flights = new clsFlightsCollection();
        //set the data surce to the llist of flights in the collection 
        lstsch.DataSource = Flights.AllFlights;
        //set the name of the primary key 
        lstsch.DataValueField = "FlightNo";
        //set the data field to display 
        lstsch.DataTextField = "Flight";
        //blind the data to the list
        lstsch.DataBind();
    }
}