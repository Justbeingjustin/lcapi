using System.Collections.Generic;
using System.IO;
using System.Linq;
using LendingClub;
using Xunit;

namespace LcapiTests
{
    public class ApiTest
    {
        private KeyValuePair<string, string> GetTestCredentials()
        {
            var lines = File.ReadLines(@"C:\Dropbox\Data\LocalRepos\lcapi\LCAPI\testCredentials.txt").ToList();
            return new KeyValuePair<string, string>(lines.First(), lines.Last());
        }

        private Api CreateApiObject()
        {
            var cred = GetTestCredentials();
            var investorId = cred.Key;
            var apiKey = cred.Value;

            return new Api(investorId, apiKey);
        }

        [Fact]
        public void SummaryTest()
        {
            var api = CreateApiObject();
            var task = api.GetSummaryAsync();
            var result = task.Result;

            Assert.NotNull(result);
        }
    }
}
