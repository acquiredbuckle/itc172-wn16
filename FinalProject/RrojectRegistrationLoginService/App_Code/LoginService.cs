using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginService" in code, svc and config file together.
public class LoginService : ILoginService
{
    ShowTrackerEntities db = new ShowTrackerEntities();
    public int FanLogin(string username, string password)
    {
        int key = 0;
        int pass = db.usp_FanLogin(username, password);

        if (pass != -1)
        {
            var fan = from f in db.FanLogins
                      where f.FanLoginUserName.Equals(username)
                      select new { f.FanKey };
            foreach (var f in fan)
            {
                key = (int)f.FanKey;
            }
        }
        return key;
    }

    public int FanRegistration(FanLite l)
    {
        int worked = db.usp_RegisterFan
            (l.FanName, l.FanEmail, l.FanUserName, l.FanPassword);
        return worked;
    }

     public int AddFanArtist( int fanKey, string artistName)
    {
        int result = 1;

        Fan myFan = (from f in db.Fans
                     where f.FanKey == fanKey
                     select f).First();

        Artist myArtist = (from a in db.Artists
                           where a.ArtistName.Equals(artistName)
                           select a).First();


        myFan.Artists.Add(myArtist);


        db.SaveChanges();

        return result;
    }
}
}
