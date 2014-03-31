using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NToggl.Tests
{
    [TestClass]
    public class TimeEntriesTests
    {
        private readonly string _userAgent;
        private readonly Client _client;


        public TimeEntriesTests()
        {
            string apiToken = ConfigurationManager.AppSettings["ApiToken"];
            _userAgent = ConfigurationManager.AppSettings["UserAgent"];
            _client = new Client(apiToken);
        }

        //[TestMethod]
    }
}
