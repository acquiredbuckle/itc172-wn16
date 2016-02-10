using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShowTrackLoginService" in code, svc and config file together.
public class ShowTrackLoginService : IShowTrackLoginService
{
    ShowTrackerEntities db = new ShowTrackerEntities();
    
    public int VenueLogin(string username, string password)
    {
        int key = 0;
        int pass = db.usp_venueLogin(username, password);
       
        if (pass != -1)
        {
            var ven = from v in db.Venues
                      where v.VenueName.Equals(username)
                      select new { v.VenueKey };
            foreach (var v in ven)
            {
                key = (int)v.VenueKey;
            }
        }


        return key;
    }

    public int VenueRegistration(VenueLite v)
    {
        int worked = db.usp_RegisterVenue(v.VenueName, v.VenueAddress, v.VenueCity, v.VenueState, v.VenueZipCode, v.VenuePhone, v.VenueEmail, v.VenueWebPage, v.VenueAgeRestriction, v.VenueLoginUserName, v.VenueLoginPasswordPlain);
        return worked;

    }
}
