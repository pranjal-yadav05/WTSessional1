using System;
using System.Web.UI.WebControls;
public partial class Site : System.Web.UI.MasterPage
{
    protected void rblDept_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Dept"] = rblDept.SelectedValue;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Session["Dept"] != null)
        {
            rblDept.SelectedValue = Session["Dept"].ToString();
        }
    }
} 