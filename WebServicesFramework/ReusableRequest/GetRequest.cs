using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Collections.Generic;
using WebServicesFramework.ExtentReports1;

namespace WebServicesFramework.ReusableRequest
{
   
    class GetRequest
    {
        public void getRequest(string url)
        {
            
            ExtentReprts extRept = new ExtentReprts();
            var client = new RestClient(url);
            var request = new RestRequest("", Method.GET);
            IRestResponse response = client.Execute(request);
            extRept.reportSetup("GetTest.html");
            extRept.createTest("Get Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Content);
            extRept.flushReport();
        }
    }
}
