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

        [TestMethod]
        public void Get_All_Time_Entries()
        {
            var timeEntries = _client.GetTimeEntries();
            Assert.IsTrue(timeEntries.Any());
        }

        [TestMethod]
        public void Get_Time_Entries_By_Time_Filter_Start_Date()
        {
            var timeEntries = _client.GetTimeEntries(startDate: DateTime.Now.AddYears(-1));
            Assert.IsTrue(timeEntries.Any());
        }

        [TestMethod]
        public void Get_Time_Entries_By_Time_Filter_End_Date()
        {
            var timeEntries = _client.GetTimeEntries(endDate: DateTime.Now);
            Assert.IsTrue(timeEntries.Any());
        }

        [TestMethod]
        public void Get_Time_Entries_By_Time_Filter_Start_Date_And_End_Date()
        {
            var timeEntries = _client.GetTimeEntries(startDate: DateTime.Now.AddYears(-1), endDate: DateTime.Now);
            Assert.IsTrue(timeEntries.Any());
        }

        [TestMethod]
        public void Get_Time_Entries_Of_Specific_User()
        {
            var timeEntries = _client.GetTimeEntries(user: _userAgent);
            Assert.IsTrue(timeEntries.Any());
        }

        [TestMethod]
        public void Get_Time_Entries_Of_Specific_User_In_Specific_Time()
        {
            var timeEntries = _client.GetTimeEntries(user: _userAgent, startDate: DateTime.Now.AddYears(-1), endDate: DateTime.Now);
            Assert.IsTrue(timeEntries.Any());
        }

        [TestMethod]
        public void Query_Over_Time_Entries_For_Specific_User()
        {
            var timeEntries = _client.Query<TimeEntry>().Where(te => te.User == _userAgent);
            Assert.IsTrue(timeEntries.Any());
        }
        [TestMethod]
        public void Query_Over_Time_Entries_For_Specific_Time_Range()
        {
            var timeEntries = _client.Query<TimeEntry>().Where(te => te.End < DateTime.Now && te.Start > DateTime.Now.AddYears(-1));
            Assert.IsTrue(timeEntries.Any());
        }
    }
}
