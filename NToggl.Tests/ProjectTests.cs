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
    public class ProjectTests
    {
        private readonly string _userAgent;
        private readonly Client _client;
        public ProjectTests()
        {
            string apiToken = ConfigurationManager.AppSettings["ApiToken"];
            _userAgent = ConfigurationManager.AppSettings["UserAgent"];
            _client = new Client(apiToken);
        }

        [TestMethod]
        public void Create_Project()
        {
            var project = _client.CreateProject(new Project()
            {
                Name = "ProjectName",
                Wid = 1,
                TemplateId = 1,
                IsPrivate = true,
            });
            Assert.AreEqual(project.Name, "ProjectName");
        }
        [TestMethod]
        public void Get_Project()
        {
            var project = _client.GetProject(1);
            Assert.AreEqual(project.Name == "ProjectName");
        }
        [TestMethod]
        public void Update_Project()
        {
            var project = _client.GetProject(1);
            project.Name = "ChangedName";
            var result = _client.UpdateProject(project);
            Assert.AreEqual(result.Name == "ChangedName");
        }
        [TestMethod]
        public void Delete_Project()
        {
            _client.DeleteProject(1);
        }
        [TestMethod]
        public void Get_Project_Users()
        {
            var users = _client.GetProjectUsers(1);
            Assert.IsTrue(users.Any());

        }
    }
}
