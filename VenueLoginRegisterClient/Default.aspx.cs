using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        VenueLogin();
    }
    protected void VenueLogin()
    {
        LoginServiceReference.IShowTrackLoginService stc = new LoginServiceReference.ShowTrackLoginServiceClient();
        int key = stc.VenueLogin(PasswordTextBox.Text, UserNameTexBox.Text);

        if (key != -1)
        {
            ErrorLabel.Text = "Welcome";
            Session["userKey"] = key;
        }
        else
        {
            ErrorLabel.Text = "Login Failed";
        }

    }


}