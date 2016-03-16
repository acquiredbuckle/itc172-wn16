using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        FanLogin();
    }
    
    protected void FanLogin()
    {
        RegistrationServiceReference.LoginServiceClient lsc = new RegistrationServiceReference.LoginServiceClient();
        int key = lsc.FanLogin(UserNameTextBox.Text, PasswordTextBox.Text);
        if (key != 0)
        {
            Session["FanKey"] = key;
            ResultLabel.Text = "Welcome";
        }
        else ResultLabel.Text = "Invalid Login";
    }
}