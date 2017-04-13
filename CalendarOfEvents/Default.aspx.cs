using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] events = new string[7,2];
    protected void Page_Load(object sender, EventArgs e)
    {
        events[0,0] = "4/16/2017";
        events[0,1] = "Easter";
        events[1,0] = "4/21/2017";
        events[1,1] = "Road Trip";
        events[2,0] = "5/4/2017";
        events[2,1] = "Star Wars Marathon with friends";
        events[3,0] = "5/15/2017";
        events[3,1] = "Dinner with Family";
        events[4,0] = "5/25/2017";
        events[4,1] = "Job interview";
        events[5,0] = "5/25/2017";
        events[5,1] = "Bar run with friends";
        events[6,0] = "6/12/2017";
        events[6,1] = "Hiking Trip";
    }

    protected void myCalendar_SelectionChanged(object sender, EventArgs e)
    {
        eventLabel.Text = "";
        string myDate = myCalendar.SelectedDate.ToShortDateString();
        for (int i = 0; i < 7; i++)
        {
            if (events[i, 0].Equals(myDate))
            {
                eventLabel.Text += events[i, 1] + "<br>";
            }
        }
        if (eventLabel.Text.Equals(""))
        {
            eventLabel.Text = myDate;
        }
    }
}