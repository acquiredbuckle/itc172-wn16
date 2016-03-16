using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FanArtsitService" in code, svc and config file together.
public class FanArtsitService : IFanArtsitService
{
    ShowTrackerFanDBEntities se = new ShowTrackerFanDBEntities();
    public int AddFanArtist(int fanKey, string artistName)
    {
        int result = 1;

        //get the fan. the key can come from their login
        Fan myFan = (from f in se.Fans
                     where f.FanKey == fanKey
                     select f).First();

        //get the artist by name
        Artist myArtist = (from a in se.Artists
                           where a.ArtistName.Equals(artistName)
                           select a).First();

        //add the artist to the fan;'s collection of artists
        myFan.Artists.Add(myArtist);

        //save the changes
        se.SaveChanges();

        return result;
    }





    public List<ShowInfo> GetShowsForFanArtists(int fanKey)
    {
        Fan myFan = (from f in se.Fans
                     where f.FanKey == fanKey
                     select f).First();

        List<ShowInfo> shows = new List<ShowInfo>;

        //this loop within a loop is very inefficient
        foreach (Artist a in myFan.Artists)
        {
            //get all the shows for the fan
            var shws = from s in se.Shows
                       from sd in s.ShowDetails
                       where sd.ArtistKey == a.ArtistKey
                       select new
                       {
                           s.ShowName,
                           s.ShowTime,
                           s.ShowDate,
                           s.ShowTicketInfo,
                           s.Venue.VenueName,
                           sd.Artist.ArtistName
                       };

            //loop through the shows and write them to 
            //ShowInfo objects then add those objects
            //to the list
            foreach (var sh in shws)
            {
                 ShowInfo info = new ShowInfo();
                info.ShowName = sh.ShowName;
                info.ShowDate = sh.ShowDate;
                info.ShowTicketInfo = sh.ShowTicketInfo;
                shows.Add(info);
            }
           

        }

        return shows;
    }
}
