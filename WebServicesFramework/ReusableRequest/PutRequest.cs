using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WebServicesFramework.ExtentReports1;
namespace WebServicesFramework.ReusableRequest
{
    class PutRequest
    {
        public void putRequest(string url, object body)
        {
            ExtentReprts extRept = new ExtentReprts();
            var client = new RestClient(url);
            var request = new RestRequest("", Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);

            client.Execute(request);
            IRestResponse response = client.Execute(request);
            extRept.reportSetup("PutTest.html");
            extRept.createTest("Put Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Content);
            extRept.flushReport();
        }
    }
}
