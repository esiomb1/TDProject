using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class eResultsPAge : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lstAvailable_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnGo_Click(object sender, EventArgs e)
    {
        clsWidgetCollection Bookings = new clsWidgetCollection();
       Bookings.AvailableWidgets(Convert.ToDateTime(txtStartDate.Text), Convert.ToDateTime(txtEndDate.Text));
        Int32 Index = 0;
       Int32 Count = Bookings.Count;
        lstAvailable.Items.Clear();
       while (Index < Count)
        {
           String Widget = Bookings.Widgets[Index].Widget;
            Int32 WidgetNo = Bookings.Widgets[Index].WidgetNo;
          ListItem NewItem = new ListItem(Widget, WidgetNo.ToString());
           lstAvailable.Items.Add(NewItem);
            Index++;
        }
    }

}