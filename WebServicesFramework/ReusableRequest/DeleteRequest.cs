using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WebServicesFramework.ExtentReports1;
namespace WebServicesFramework.ReusableRequest
{
    class DeleteRequest
    {
        public void deleteRequest(string url)
        {
            ExtentReprts extRept = new ExtentReprts();
            var client = new RestClient(url);
            var request = new RestRequest("", Method.DELETE);
            IRestResponse response = client.Execute(request);
            extRept.reportSetup("DeleteTest.html");
            extRept.createTest("Delete Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Content);
            extRept.flushReport();
        }
    }
}
