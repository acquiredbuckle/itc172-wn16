using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShowTrackLoginService" in both code and config file together.
[ServiceContract]
public interface IShowTrackLoginService
{
    [OperationContract]
    int VenueLogin(string username, string password);

    [OperationContract]
    int VenueRegistration(VenueLite v);

    [OperationContract]
    int AddArtist(ArtistLite a);

    [OperationContract]
    int AddShow(ShowLite s);

    [OperationContract]
    int AddShowDetail(ShowDetailLite sd);
}


[DataContract]
public class VenueLite
{

    [DataMember]
    public string VenueName { set; get; }

    [DataMember]
    public string VenueAddress { set; get; }

    [DataMember]
    public string VenueCity { set; get; }

    [DataMember]
    public string VenueState { set; get; }

    [DataMember]
    public string VenueZipCode { set; get; }

    [DataMember]
    public string VenuePhone { set; get; }

    [DataMember]
    public string VenueEmail { set; get; }

    [DataMember]
    public string VenueWebPage { set; get; }

    [DataMember]
    public int VenueAgeRestriction { set; get; }

    [DataMember]
    public string VenueLoginUserName { set; get; }

    [DataMember]
    public string VenueLoginPasswordPlain { set; get; }
}

[DataContract]
public class ShowLite 
{
    [DataMember]
    public string ShowName { get; set; }

    [DataMember]
    public int VenueKey { get; set; }

    [DataMember]
    public DateTime ShowDate { get; set; }

    [DataMember]
    public TimeSpan ShowTime { get; set; }

    [DataMember]
    public string ShowTicketInfo { get; set; }


}

[DataContract]
public class ShowDetailLite
{
    [DataMember]
    public int Showkey { get; set; }

    [DataMember]
    public int ArtistKey { get; set; }

    [DataMember]
    public TimeSpan ShowDetailArtistStartTime { get; set; }

    [DataMember]
    public string ShowDetailAdditional { get; set; }

}

[DataContract]
public class ArtistLite
{
    [DataMember]
    public string ArtistName { get; set; }

    [DataMember]
    public string ArtistEmail { get; set; }

    [DataMember]
    public string ArtistWebPage { get; set; }

    [DataMember]
    public DateTime ArtistDateEntered { get; set; }

  
}