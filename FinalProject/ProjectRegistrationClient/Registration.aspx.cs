using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        RegisterFan();
    }

    protected void RegisterFan()
    {
        RegistrationServiceReference.LoginServiceClient lsc = new RegistrationServiceReference.LoginServiceClient();
        RegistrationServiceReference.FanLite fLite = new RegistrationServiceReference.FanLite();
        fLite.FanName = FanNameTextBox.Text;
        fLite.FanEmail = EmailTextBox.Text;
        fLite.FanUserName = UserNameTextBox.Text;
        fLite.FanPassword = PasswordTextBox.Text;

        try
        {
            int result = lsc.FanRegistration(fLite);
            if (result == 1)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                ErrorLabel.Text = "Registration not processed";
            }
        }
        catch (Exception ex)
        {
            ErrorLabel.Text = ex.Message;
        }
    }
}