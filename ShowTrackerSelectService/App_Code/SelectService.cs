using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ISelectService" in code, svc and config file together.
public class SelectService : ISelectService
{
    ShowTrackerEntities stde = new ShowTrackerEntities();
    public List<string> GetArtists()
    {
        List<string> artists = new List<string>();

        var arts = from a in stde.Artists
                   select new { a.ArtistName };
        foreach (var v in arts)
        {
            artists.Add(v.ArtistName.ToString());
        }
        return artists;
    }

    public List<string> GetShows()
    {
        List<string> shows = new List<string>();

        var show = from s in stde.Shows
                   select new { s.ShowName };
        foreach (var v in show)
        {
            shows.Add(v.ShowName.ToString());
        }
        return shows;
    }

    public List<string> GetVenues()
    {
        List<string> venues = new List<string>();

        var vens = from ve in stde.Venues
                   select new { ve.VenueName };
        foreach (var v in vens)
        {
            venues.Add(v.VenueName.ToString());
        }
        return venues;
    }

    public List<ShowLite> GetShowsByVenueName(string venueName)
    {
        List<ShowLite> shows = new List<ShowLite>();

        var show = from s in stde.Shows
                   where s.Venue.VenueName.Equals(venueName)
                   select new
                   {
                       s.ShowName,
                       s.ShowDate,
                  
                   };

        foreach (var v in shows)
        {
            ShowLite lite = new ShowLite();
            lite.ShowName = v.ShowName;
            lite.ShowDate = v.ShowDate;
            shows.Add(lite);
        }
  

        return shows;
    }


}
