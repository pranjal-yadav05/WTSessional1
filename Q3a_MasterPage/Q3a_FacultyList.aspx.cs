using System;
using System.Collections.Generic;
public partial class Q3a_FacultyList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            UpdateFaculty();
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        UpdateFaculty();
    }
    private void UpdateFaculty()
    {
        string dept = Session["Dept"] as string ?? "IT";
        lblDept.Text = $"Department: {dept}";
        lstFaculty.Items.Clear();
        List<string> faculty = new List<string>();
        switch (dept)
        {
            case "IT": faculty.AddRange(new[] { "IT Faculty 1", "IT Faculty 2", "IT Faculty 3" }); break;
            case "CE": faculty.AddRange(new[] { "CE Faculty 1", "CE Faculty 2", "CE Faculty 3" }); break;
            case "EC": faculty.AddRange(new[] { "EC Faculty 1", "EC Faculty 2", "EC Faculty 3" }); break;
        }
        foreach (var f in faculty)
            lstFaculty.Items.Add(f);
    }
} 