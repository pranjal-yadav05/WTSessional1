using System;
public partial class Q2a_ImageMap : System.Web.UI.Page
{
    protected void ImageMap1_Click(object sender, System.Web.UI.WebControls.ImageMapEventArgs e)
    {
        lblResult.Text = $"You clicked: {e.PostBackValue}";
    }
} 