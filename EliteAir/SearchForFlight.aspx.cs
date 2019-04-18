using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace EliteAir
{
    public partial class SearchForFlight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if this is the fist time the page is displayed 
            if (IsPostBack == false)
            {
                //update the list box
                DisplayFlights();
          
            }
        }
        void DisplayFlights()
        {
            //create an instance of the County Collection
            Class_Library.clsFlightsCollection Flights = new Class_Library.clsFlightsCollection();
            //set the data source to the list of counties in the collection
            lstSF.DataSource = Flights.FlightsList;
            //set the name of the primary key
            lstSF.DataValueField = "FlightNo";
            //set the data field to display
            lstSF.DataTextField = "DepartureAirport";
            lstSF.DataTextField = "DestinationAirport";
            lstSF.DataTextField = "DepartureDate";
            lstSF.DataTextField = "ArrivalTime";
            lstSF.DataTextField = "ArrivalDate";
            lstSF.DataTextField = "DepartureTime";
            lstSF.DataTextField = "Duration";
            lstSF.DataTextField = "Cost";
            //bind the data to the list
            lstSF.DataBind();

        }

        protected void lstSF_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update the list box
            DisplayFlights();
        }

     
    }
}