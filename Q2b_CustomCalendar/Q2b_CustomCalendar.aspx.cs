using System;
using System.Drawing;
using System.Web.UI.WebControls;
public partial class Q2b_CustomCalendar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) { }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        // Monday as holiday
        if (e.Day.Date.DayOfWeek == DayOfWeek.Monday)
        {
            e.Cell.BackColor = Color.Red;
            //e.Cell.ToolTip = "Holiday (Monday)";
        }
        // Event: 21st-25th Aug 2024
        if (e.Day.Date >= new DateTime(2024, 8, 21) && e.Day.Date <= new DateTime(2024, 8, 25))
        {
            e.Cell.BackColor = Color.Yellow;
           // e.Cell.Controls.Clear();
           // e.Cell.Controls.Add(new Literal { Text = "Event" });
            e.Day.IsSelectable = false;
        }
        // Holidays: 15th Aug, 19th Aug
        if (e.Day.Date == new DateTime(2024, 8, 15))
        {
            e.Cell.BackColor = Color.LightGreen;
            e.Cell.ToolTip = "Independence Day";
            e.Cell.Controls.Add(new Literal { Text = "<br/>Independence Day" });
        }
        if (e.Day.Date == new DateTime(2024, 8, 19))
        {
            e.Cell.BackColor = Color.LightBlue;
            e.Cell.ToolTip = "Rakshabandhan";
            e.Cell.Controls.Add(new Literal { Text = "<br/>Rakshabandhan" });
        }
    }
} 