using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoginService" in both code and config file together.
[ServiceContract]
public interface ILoginService
{
	[OperationContract]
	int FanLogin(string username, string password);

    [OperationContract]
    int FanRegistration(FanLite l);
}

[DataContract]
public class FanLite
{
    [DataMember]
    public string FanName { set; get; }

    [DataMember]
    public string FanEmail { set; get; }

    [DataMember]
    public string FanUserName { set; get; }

    [DataMember]
    public string FanPassword { set; get; }
}
