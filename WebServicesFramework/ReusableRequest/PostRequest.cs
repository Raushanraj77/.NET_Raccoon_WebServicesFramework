using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WebServicesFramework.ExtentReports1;
namespace WebServicesFramework.ReusableRequest
{
    class PostRequest
    {
        public void postRequest(string url, object body)
        {
            ExtentReprts extRept = new ExtentReprts();
            var client = new RestClient(url);
            var request = new RestRequest("", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);
           
            client.Execute(request);
            IRestResponse response = client.Execute(request);
            extRept.reportSetup("PostTest.html");
            extRept.createTest("Post Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Content);
            extRept.flushReport();
        }
    }
}
