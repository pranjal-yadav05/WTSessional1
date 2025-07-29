using System;
using System.Web.UI.WebControls;
public partial class Q3b_ShopPurchase : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cblItems.Items.Add(new ListItem("Pen", "10"));
            cblItems.Items.Add(new ListItem("Notebook", "30"));
            cblItems.Items.Add(new ListItem("Pencil", "5"));
            cblItems.Items.Add(new ListItem("Eraser", "3"));
            cblItems.Items.Add(new ListItem("Scale", "7"));
        }
    }
    protected void cblItems_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateTotal();
    }
    protected void btnPurchase_Click(object sender, EventArgs e)
    {
        UpdateTotal();
        string items = "";
        foreach (ListItem item in cblItems.Items)
        {
            if (item.Selected)
                items += item.Text + ", ";
        }
        if (items.EndsWith(", "))
            items = items.Substring(0, items.Length - 2);
        lblResult.Text = $"Purchased: {items}<br/>Total Paid: {txtTotal.Text}";
    }
    private void UpdateTotal()
    {
        int total = 0;
        foreach (ListItem item in cblItems.Items)
        {
            if (item.Selected)
                total += int.Parse(item.Value);
        }
        txtTotal.Text = total.ToString();
    }
} 