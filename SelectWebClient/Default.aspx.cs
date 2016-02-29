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

    protected void VenueButton_Click(object sender, EventArgs e)
    {
        GetVenues();
    }
    protected String GetVenues()
    {
        ServiceReference.ShowTrackerServiceClient() stc = new ServiceReference.ShowTrackerServiceClient();
   
      
        return GetVenues();
        
    }
    protected void ArtistButton_Click(object sender, EventArgs e)
    {
        stc.GetArtists();
    }
    protected String GetVenues()
    {
        ServiceReference.ShowTrackerServiceClient() stc = new ServiceReference.ShowTrackerServiceClient();
   
      
        return stc.GetArtists();
        
    }
    protected void ShowsButton_Click(object sender, EventArgs e)
    {
        GetShows();
    }
    protected String GetShows()
    {
        ServiceReference.ShowTrackerServiceClient() stc = new ServiceReference.ShowTrackerServiceClient();
   
      
        return stc.GetShows();
        
    }



}