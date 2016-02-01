using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IISelectService" in both code and config file together.
[ServiceContract]
public interface ISelectService
{
    [OperationContract]
    List<string> GetArtists();

    [OperationContract]
    List<string> GetShows();

    [OperationContract]
    List<string> GetVenues();

    [OperationContract]
    List<ShowLite> GetShowsByVenueName(string venueName);

 
	
}

[DataContract]
public class ShowLite
{
    [DataMember]
    public string VenueName { set; get; }

    [DataMember]
    public string ArtistName { set; get; }

    [DataMember]
    public string ShowName { set; get; }

    [DataMember]
    public DateTime ShowDate { set; get; }

}
