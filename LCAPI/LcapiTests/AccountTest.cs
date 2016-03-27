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

        [Fact]
        public void WithdrawFundsTest()
        {
            var api = CreateApiObject();

            var task = api.WithdrawFundsAsync(1.23m);
            var result = task.Result;

            Assert.NotNull(result);
        }

        [Fact]
        public void PendingTransfersTest()
        {
            var api = CreateApiObject();

            var task = api.GetPendingTransfersAsync();
            var result = task.Result;

            Assert.NotNull(result);
        }

        [Fact]
        public void CancelTransfersTest()
        {
            var api = CreateApiObject();

            var task = api.GetPendingTransfersAsync();
            var result = task.Result;

            var toCancel = result.FirstOrDefault(r => r.Cancellable);
            var cancelTask = api.CancelTransferAsync(toCancel.TransferId);
            var cancelResult = cancelTask.Result;

            Assert.NotNull(cancelResult);
        }

        [Fact]
        public void OwnedNotesTest()
        {
            var api = CreateApiObject();

            var task = api.GetOwnedNotesAsync();
            var result = task.Result;

            Assert.NotNull(result);
        }
    }
}
