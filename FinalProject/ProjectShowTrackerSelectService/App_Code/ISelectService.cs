using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISelectService" in both code and config file together.
[ServiceContract]
public interface ISelectService
{
	[OperationContract]
	List<string> GetVenues();

    [OperationContract]
    List<string> GetArtists();

    [OperationContract]
    List<string> GetShows();

    [OperationContract]
    List<ShowInfo> GetShowsByVenue(string VenueName);

    [OperationContract]
    List<ShowInfo> GetShowsByArtist(string ArtistName);
}

[DataContract]
public class ShowInfo
{
    [DataMember]
    public String ShowName { set; get; }

    [DataMember]
    public DateTime ShowDate { set; get; }

    [DataMember]
    public String ShowTicketInfo { set; get; }
}
