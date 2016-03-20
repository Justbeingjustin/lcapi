using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LendingClub;
using Xunit;

namespace LcapiTests
{
    public class AccountTest
    {
        private KeyValuePair<string, string> GetTestCredentials()
        {
            var lines = File.ReadLines(@"C:\Dropbox\Data\LocalRepos\lcapi\LCAPI\testCredentials.txt").ToList();
            return new KeyValuePair<string, string>(lines.First(), lines.Last());
        }

        private Account CreateApiObject()
        {
            var cred = GetTestCredentials();
            var apiKey = cred.Key;
            var investorId = cred.Value;

            return new Account(investorId, apiKey);
        }

        [Fact]
        public void SummaryTest()
        {
            var api = CreateApiObject();
            var task = api.GetSummaryAsync();
            var result = task.Result;

            Assert.NotNull(result);
        }

        [Fact]
        public void AddFundsTest()
        {
            var api = CreateApiObject();

            var task = api.AddFundsScheduledAsync(1.23m, DateTime.Parse("02/01/2040"));
            var result = task.Result;

            Assert.NotNull(result);
        }
    }
}
