using System;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NToggl.Tests
{
    [TestClass]
    public class WorkspaceTests
    {
        private readonly string _userAgent;
        private readonly Client _client;
        public WorkspaceTests()
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
    }
}
