using System;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NToggl.Tests
{
    [TestClass]
    public class ClientTests
    {
        private readonly string _userAgent;
        private readonly Client _client;
        public ClientTests()
        {
            string apiToken = ConfigurationManager.AppSettings["ApiToken"];
            _userAgent = ConfigurationManager.AppSettings["UserAgent"];
            _client = new Client(apiToken);
        }

        [TestMethod]
        public void Get_All_Workspaces()
        {
            var workspaces = _client.GetWorkspaces();
            Assert.IsTrue(workspaces.Any());
        }

        [TestMethod]
        public void Get_Full_Detailed_Report_For_First_Workspace()
        {
            var workspace = _client.GetWorkspaces().FirstOrDefault();
            Assert.IsNotNull(workspace);
            var timeEntries = _client.GetDetailedReport(_userAgent, workspace.Id);
            Assert.IsTrue(timeEntries.Any());
        }

        [TestMethod]
        public void Get_Detailed_Report_For_First_Workspace_By_Time_Filter_Since()
        {
            var workspace = _client.GetWorkspaces().FirstOrDefault();
            Assert.IsNotNull(workspace);
            var timeEntries = _client.GetDetailedReport(_userAgent, workspace.Id, since: DateTime.Now.AddYears(-1));
            Assert.IsTrue(timeEntries.Any());
        }

        [TestMethod]
        public void Get_Detailed_Report_For_First_Workspace_By_Time_Filter_Until()
        {
            var workspace = _client.GetWorkspaces().FirstOrDefault();
            Assert.IsNotNull(workspace);
            var timeEntries = _client.GetDetailedReport(_userAgent, workspace.Id, until: DateTime.Now);
            Assert.IsTrue(timeEntries.Any());
        }

        [TestMethod]
        public void Get_Detailed_Report_For_First_Workspace_By_Time_Filter_Since_And_Until()
        {
            var workspace = _client.GetWorkspaces().FirstOrDefault();
            Assert.IsNotNull(workspace);
            var timeEntries = _client.GetDetailedReport(_userAgent, workspace.Id, since: DateTime.Now.AddYears(-1), until: DateTime.Now);
            Assert.IsTrue(timeEntries.Any());
        }
    }
}
