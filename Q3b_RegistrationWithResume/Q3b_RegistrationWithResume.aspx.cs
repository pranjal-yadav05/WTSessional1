using System;
public partial class Q3b_RegistrationWithResume : System.Web.UI.Page
{
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (!fuResume.HasFile)
        {
            lblResult.Text = "Please upload a resume.";
            return;
        }
        if (fuResume.PostedFile.ContentType != "application/pdf")
        {
            lblResult.Text = "Only PDF files are allowed.";
            return;
        }
        if (fuResume.PostedFile.ContentLength > 10240)
        {
            lblResult.Text = "File size must be less than 10KB.";
            return;
        }
        string details = $"Name: {txtName.Text}<br/>Enrollment: {txtEnroll.Text}<br/>Contact: {txtContact.Text}<br/>Email: {txtEmail.Text}<br/>Resume: {fuResume.FileName}";
        lblResult.Text = details;
    }
} 