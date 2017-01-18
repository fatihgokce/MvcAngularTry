using MvcAngularTry.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace MvcAngularTry
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        public void DoWork()
        {
            // Add your operation implementation here
            return;
        }
        [OperationContract]
        [WebGet]
        public List<Fake> GetJsonR()
        {
            List<Fake> dts = new List<Fake> { 
            new Fake{age=11,name="ka",snippet="blaaaaa",isActive=true},
            new Fake{age=12,name="aa",snippet="claaaaa",isActive=false},
            new Fake{age=13,name="da",snippet="dblaaaaa"},
            new Fake{age=14,name="fa",snippet="elaaaaa",isActive=true},
            };
            return dts;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
