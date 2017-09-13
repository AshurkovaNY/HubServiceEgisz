using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceNsi
{
    [ServiceContract]
    public interface IServiceNsi
    {

        [OperationContract]
        [WebGet(UriTemplate = "/Getf001",
            ResponseFormat = WebMessageFormat.Json)]
        string Getf001();

        [OperationContract]
        [WebGet(UriTemplate = "/Getf002",
           ResponseFormat = WebMessageFormat.Json)]
        string Getf002();
    }
 
}
