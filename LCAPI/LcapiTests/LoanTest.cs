using System.Collections.Generic;
using System.IO;
using System.Linq;
using LendingClub;
using Xunit;

namespace LcapiTests
{
    public class LoanTest
    {
        private KeyValuePair<string, string> GetTestCredentials()
        {
            var lines = File.ReadLines(@"C:\Dropbox\Data\LocalRepos\lcapi\LCAPI\testCredentials.txt").ToList();
            return new KeyValuePair<string, string>(lines.First(), lines.Last());
        }

        private Loan CreateApiObject()
        {
            var cred = GetTestCredentials();
            var apiKey = cred.Value;

            return new Loan(apiKey);
        }

        [Fact]
        public void ListingTest()
        {
            var api = CreateApiObject();
            var listing = api.GetListingAsync().Result;

            Assert.NotNull(listing);
        }
    }
}
