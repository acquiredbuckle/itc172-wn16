using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SelectService" in code, svc and config file together.
public class SelectService : ISelectService
{
    ShowTrackerDBEntities stdb = new ShowTrackerDBEntities();
    public List<string> GetVenues()
    {
        List<string> venues = new List<string>();

        var ven = from v in stdb.Venues
                  select new { v.VenueName };
        foreach (var n in ven)
        {
            venues.Add(n.VenueName.ToString());
        }
        return venues;
    }

    public List<string> GetArtists()
    {
        List<string> artists = new List<string>();

        var art = from a in stdb.Artists
                  select new { a.ArtistName };
        foreach (var n in art)
        {
            artists.Add(n.ArtistName.ToString());
        }
        return artists;
    }

    public List<string> GetShows()
    {
        List<string> shows = new List<string>();

        var sho = from s in stdb.Shows
                  select new { s.ShowName };
        foreach (var n in sho)
        {
            shows.Add(n.ShowName.ToString());
        }
        return shows; ;
    }

    public List<ShowInfo> GetShowsByVenue(string VenueName)
    {
        List<ShowInfo> shows = new List<ShowInfo>();

        var sho = from s in stdb.Shows
                  where s.Venue.VenueName.Equals(VenueName)
                  select new
                  {
                      s.ShowName,
                      s.ShowDate,
                      s.ShowTicketInfo
                  };

        foreach (var s in sho)
        {
            ShowInfo info = new ShowInfo();
            info.ShowName = s.ShowName;
            info.ShowDate = s.ShowDate;
            info.ShowTicketInfo = s.ShowTicketInfo;
            shows.Add(info);
        }
        
        return shows;
    }

    public List<ShowInfo> GetShowsByArtist(string ArtistName)
    {
        List<ShowInfo> shows = new List<ShowInfo>();

        var sho = from s in stdb.ShowDetails
                  where s.Artist.ArtistName.Equals(ArtistName)
                  select new
                  {
                      s.Show.ShowName,
                      s.Show.ShowDate,
                      s.Show.ShowTicketInfo

                  };

        foreach (var s in sho)
        {
            ShowInfo info = new ShowInfo();
            info.ShowName = s.ShowName;
            info.ShowDate = s.ShowDate;
            info.ShowTicketInfo = s.ShowTicketInfo;
            shows.Add(info);
        }

        return shows;
    }
}
