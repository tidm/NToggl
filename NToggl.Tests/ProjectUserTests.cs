using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NToggl.Tests
{
    [TestClass]
    public class ProjectUserTests
    {
        private readonly string _userAgent;
        private readonly Client _client;
        public ProjectUserTests()
        {
            string apiToken = ConfigurationManager.AppSettings["ApiToken"];
            _userAgent = ConfigurationManager.AppSettings["UserAgent"];
            _client = new Client(apiToken);
        }
        [TestMethod]
        public void Create_Project_User()
        {
            var project = _client.GetProject(1);
            var user = _client.GetUser(1);
            var result = _client.CreateProjectUser(new User()
            {
                Project = project,
                User = user,
                Rate = 0.4,
                IsManager = true
            });
            Assert.AreNotEqual(result.Id, 0);
        }
        [TestMethod]
        public void Update_Project_User()
        {
            var projectUser = _client.GetProjectUser(1);
            projectUser.Rate = 15;
            _client.UpdateProjectUser(projectUser);
            Assert.AreEqual(projectUser.Rate, 15);
        }
        [TestMethod]
        public void Delete_Project_User()
        {
            _client.DeleteProjectUser(1);
        }

    }
}
