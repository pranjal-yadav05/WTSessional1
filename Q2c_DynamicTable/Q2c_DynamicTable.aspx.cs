using System;
using System.Web.UI.WebControls;
public partial class Q2c_DynamicTable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            for (int i = 1; i <= 5; i++)
            {
                ddlRows.Items.Add(i.ToString());
                ddlCols.Items.Add(i.ToString());
            }
            rblControlType.SelectedIndex = 0;
        }
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        int rows = int.Parse(ddlRows.SelectedValue);
        int cols = int.Parse(ddlCols.SelectedValue);
        string controlType = rblControlType.SelectedValue;
        Table table = new Table();
        for (int i = 0; i < rows; i++)
        {
            TableRow tr = new TableRow();
            for (int j = 0; j < cols; j++)
            {
                TableCell tc = new TableCell();
                switch (controlType)
                {
                    case "TextBox":
                        tc.Controls.Add(new TextBox());
                        break;
                    case "HyperLink":
                        HyperLink hl = new HyperLink { Text = "Link", NavigateUrl = "#" };
                        tc.Controls.Add(hl);
                        break;
                    case "LinkButton":
                        LinkButton lb = new LinkButton { Text = "Button" };
                        tc.Controls.Add(lb);
                        break;
                }
                tr.Cells.Add(tc);
            }
            table.Rows.Add(tr);
        }
        phTable.Controls.Clear();
        phTable.Controls.Add(table);
    }
} 