using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFRestCrud
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INorthwind" in both code and config file together.
    [ServiceContract]
    public interface INorthwind
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "getstring/")]
        string Getreststring();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "getregions/")]
        List<RegionVM> GetRegions();

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "addregion/")]
        bool AddRegion(Region region);
    }
}
