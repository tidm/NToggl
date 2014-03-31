using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NToggl.Tests
{
    [TestClass]
    class DetailedReportTests
    {
        private readonly string _userAgent;
        private readonly Client _client;

        public DetailedReportTests()
        {
            string apiToken = ConfigurationManager.AppSettings["ApiToken"];
            _userAgent = ConfigurationManager.AppSettings["UserAgent"];
            _client = new Client(apiToken);
        }
        //[TestMethod]
        //public void Get_Full_Detailed_Report_For_First_Workspace()
        //{
        //    var workspace = _client.GetWorkspaces().FirstOrDefault();
        //    Assert.IsNotNull(workspace);
        //    var timeEntries = _client.GetDetailedReport(_userAgent, workspace.Id);
        //    Assert.IsTrue(timeEntries.Any());
        //}

        //[TestMethod]
        //public void Get_Detailed_Report_For_First_Workspace_By_Time_Filter_Since()
        //{
        //    var workspace = _client.GetWorkspaces().FirstOrDefault();
        //    Assert.IsNotNull(workspace);
        //    var timeEntries = _client.GetDetailedReport(_userAgent, workspace.Id, since: DateTime.Now.AddYears(-1));
        //    Assert.IsTrue(timeEntries.Any());
        //}

        //[TestMethod]
        //public void Get_Detailed_Report_For_First_Workspace_By_Time_Filter_Until()
        //{
        //    var workspace = _client.GetWorkspaces().FirstOrDefault();
        //    Assert.IsNotNull(workspace);
        //    var timeEntries = _client.GetDetailedReport(_userAgent, workspace.Id, until: DateTime.Now);
        //    Assert.IsTrue(timeEntries.Any());
        //}

        //[TestMethod]
        //public void Get_Detailed_Report_For_First_Workspace_By_Time_Filter_Since_And_Until()
        //{
        //    var workspace = _client.GetWorkspaces().FirstOrDefault();
        //    Assert.IsNotNull(workspace);
        //    var timeEntries = _client.GetDetailedReport(_userAgent, workspace.Id, since: DateTime.Now.AddYears(-1), until: DateTime.Now);
        //    Assert.IsTrue(timeEntries.Any());
        //}
    }
}
