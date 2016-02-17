using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VenueRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {

    }

    protected void SubmitVenue()
    {
        LoginServiceReference.IShowTrackLoginService stc = new LoginServiceReference.ShowTrackLoginServiceClient();

        LoginServiceReference.VenueLite vLite = new LoginServiceReference.VenueLite();

        vLite.VenueName = VenueNameTextBox.Text;
        vLite.VenueAddress = VenueAddressTextBox.Text;
        vLite.VenueCity = VenueCityTextBox.Text;
        vLite.VenueState = VenueStateTextBox.Text;
        vLite.VenueZipCode = VenueZipCodeTextBox.Text;
        vLite.VenuePhone = VenuePhoneTextBox.Text;
        vLite.VenueEmail = EmailTextBox.Text;
        vLite.VenueWebPage = VenueWebPageTextBox.Text;
        vLite.VenueAgeRestriction = Int32.Parse("AgeRestrictionTextBox.Text");
        vLite.VenueLoginUserName = UserNameTextBox.Text;
        vLite.VenueLoginPasswordPlain = PasswordTextBox.Text;

        //todo add rest of fields

        int result = stc.VenueRegistration(vLite);

        if (result != -1)
        {
            ResultLabel.Text = "Successfully registered";
        }
        else
        {
            ResultLabel.Text = "Successfully failed";
        }
    }
}