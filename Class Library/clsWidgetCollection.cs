using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsBookingCollection
/// </summary>
public class clsWidgetCollection
{
    private List<clsWidget> mWidgets = new List<clsWidget>();

    public clsWidgetCollection()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<clsWidget> Widgets
    {
        get
        {
            return mWidgets;
        }
    }

    public Int32 Count
    {
        get
        {
            return mWidgets.Count;
        }
    }

    public void AvailableWidgets(DateTime StartDate, DateTime EndDate)
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@StartDate", StartDate);
        DB.AddParameter("@EndDate", EndDate);
        DB.Execute("sproc_tblFlights_CheckAvailablity");
        mWidgets = new List<clsWidget>();
        Int32 Index = 0;
        Int32 Count = DB.Count;
        while (Index < Count)
        {
            clsWidget ABooking = new clsWidget();
            ABooking.WidgetNo = Convert.ToInt32(DB.DataTable.Rows[Index]["WidgetNo"]);
            ABooking.Widget = Convert.ToString(DB.DataTable.Rows[Index]["Widget"]);
            mWidgets.Add(ABooking);
            Index++;
        }
    }
}