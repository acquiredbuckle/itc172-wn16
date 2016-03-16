using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFanArtsitService" in both code and config file together.
[ServiceContract]
public interface IFanArtsitService
{
	[OperationContract]
    int AddFanArtist(int fanKey, string artistName);

    [OperationContract]
    List<ShowInfo> GetShowsForFanArtists(int fanKey);

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
}
