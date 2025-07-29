using System;
public partial class Q3a_StudentRegistrationWithValidators : System.Web.UI.Page
{
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            lblResult.Text = $"Name: {txtName.Text}<br/>Email: {txtEmail.Text}<br/>Age: {txtAge.Text}";
        }
    }
    protected void custAge_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
    {
        int age = Convert.ToInt32(txtAge.Text);
        if (age >= 18)
            args.IsValid = true;
        else
            args.IsValid = false;
    }
} 