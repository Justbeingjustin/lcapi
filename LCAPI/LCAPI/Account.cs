using System;
using System.Threading.Tasks;
using LendingClub.Models;

namespace LendingClub
{
    public class Account : ApiBase
    {
        public string InvestorId { get; }

        public string Url => $"{BaseUrl}/accounts/{InvestorId}";

        public Account(string apiKey, string investorId) : base(apiKey)
        {
            InvestorId = investorId;
        }

        #region Summary

        protected string SummaryUrl => $"{Url}/summary";

        public Task<AccountSummary> GetSummaryAsync()
        {
            return Client.GetAsync<AccountSummary>(SummaryUrl);
        }

        #endregion

        #region Available Cash

        protected string AvailableCashUrl => $"{Url}/availablecash";

        public Task<AccountAvailableCash> GetAvailableCashAsync()
        {
            return Client.GetAsync<AccountAvailableCash>(AvailableCashUrl);
        }

        #endregion

        #region Transfer Funds

        protected string AddFundsUrl => $"{Url}/funds/add";

        private Task<AccountAddFunds> AddFundsAsync<T>(T request)
        {
            return Client.PostAsync<AccountAddFunds, T>(AddFundsUrl, request);
        }

        public Task<AccountAddFunds> AddFundsNowAsync(decimal amount)
        {
            return AddFundsAsync(new
            {
                transferFrequency = "LOAD_NOW",
                amount
            });
        }

        public Task<AccountAddFunds> AddFundsScheduledAsync(decimal amount, DateTime startDate)
        {
            return AddFundsAsync(new
            {
                transferFrequency = "LOAD_ONCE",
                amount,
                startDate = startDate.ToUniversalTime()
            });
        }

        public Task<AccountAddFunds> AddFundsRecurringWeeklyAsync(decimal amount, DateTime startDate,
            DateTime endDate)
        {
            return AddFundsAsync(new
            {
                transferFrequency = "LOAD_WEEKLY",
                amount,
                startDate = startDate.ToUniversalTime(),
                endDate = endDate.ToUniversalTime()
            });
        }

        public Task<AccountAddFunds> AddFundsRecurringBiWeeklyAsync(decimal amount, DateTime startDate,
            DateTime endDate)
        {
            return AddFundsAsync(new
            {
                transferFrequency = "LOAD_BIWEEKLY",
                amount,
                startDate = startDate.ToUniversalTime(),
                endDate = endDate.ToUniversalTime()
            });
        }

        public Task<AccountAddFunds> AddFundsRecurringBiMonthlyAsync(decimal amount, DateTime startDate,
            DateTime endDate)
        {
            return AddFundsAsync(new
            {
                transferFrequency = "LOAD_ON_DAY_1_AND_16",
                amount,
                startDate = startDate.ToUniversalTime(),
                endDate = endDate.ToUniversalTime()
            });
        }

        public Task<AccountAddFunds> AddFundsRecurringMonthlyAsync(decimal amount, DateTime startDate,
            DateTime endDate)
        {
            return AddFundsAsync(new
            {
                transferFrequency = "LOAD_MONTHLY",
                amount,
                startDate = startDate.ToUniversalTime(),
                endDate = endDate.ToUniversalTime()
            });
        }

        protected string WithdrawFundsUrl => $"{Url}/funds/withdraw";

        private Task<AccountWithdrawFunds> WithdrawFundsAsync<T>(T request)
        {
            return Client.PostAsync<AccountWithdrawFunds, T>(WithdrawFundsUrl, request);
        }

        public Task<AccountWithdrawFunds> WithdrawFundsAsync(decimal amount)
        {
            return WithdrawFundsAsync(new { amount });
        }

        #endregion
    }
}
