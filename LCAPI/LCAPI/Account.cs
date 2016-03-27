using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Provides a summary of the investor's account
        /// </summary>
        /// <returns>Summary of the investor's account</returns>
        public Task<AccountSummary> GetSummaryAsync()
        {
            return Client.GetAsync<AccountSummary>(SummaryUrl);
        }

        #endregion

        #region Available Cash

        protected string AvailableCashUrl => $"{Url}/availablecash";

        /// <summary>
        /// Provides the most up to date value of the cash available in the investor's account
        /// </summary>
        /// <returns>Value of the cash available in the investor's account</returns>
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

        /// <summary>
        /// Add funds to the investor's account once, immediately
        /// </summary>
        /// <param name="amount">Amount of funds to add</param>
        /// <remarks>For loading funds immediately and one time</remarks>
        /// <returns>Details of a transaction to add funds</returns>
        public Task<AccountAddFunds> AddFundsNowAsync(decimal amount)
        {
            return AddFundsAsync(new
            {
                transferFrequency = "LOAD_NOW",
                amount
            });
        }

        /// <summary>
        /// Add funds to the investor's account once, scheduled for a future date
        /// </summary>
        /// <param name="amount">Amount of funds to add</param>
        /// <param name="startDate">Future transfer date</param>
        /// <remarks>For loading funds one time scheduled for future date</remarks>
        /// <returns>Details of a transaction to add funds</returns>
        public Task<AccountAddFunds> AddFundsScheduledAsync(decimal amount, DateTime startDate)
        {
            return AddFundsAsync(new
            {
                transferFrequency = "LOAD_ONCE",
                amount,
                startDate = startDate.ToUniversalTime()
            });
        }

        /// <summary>
        /// Add funds to the investor's account, recurring weekly
        /// </summary>
        /// <param name="amount">Amount of funds to add</param>
        /// <param name="startDate">Recurring transfer start date</param>
        /// <param name="endDate">Recurring transfer end date</param>
        /// <remarks>For loading funds recurring weekly</remarks>
        /// <returns>Details of a transaction to add funds</returns>
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

        /// <summary>
        /// Add funds to the investor's account, recurring bi-weekly
        /// </summary>
        /// <param name="amount">Amount of funds to add</param>
        /// <param name="startDate">Recurring transfer start date</param>
        /// <param name="endDate">Recurring transfer end date</param>
        /// <remarks>For loading funds recurring bi-weekly</remarks>
        /// <returns>Details of a transaction to add funds</returns>
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

        /// <summary>
        /// Add funds to the investor's account, recurring bi-monthly on the 1st and 16th of every month
        /// </summary>
        /// <param name="amount">Amount of funds to add</param>
        /// <param name="startDate">Recurring transfer start date</param>
        /// <param name="endDate">Recurring transfer end date</param>
        /// <returns>Details of a transaction to add funds</returns>
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

        /// <summary>
        /// Add funds to the investor's account, recurring monthly
        /// </summary>
        /// <param name="amount">Amount of funds to add</param>
        /// <param name="startDate">Recurring transfer start date</param>
        /// <param name="endDate">Recurring transfer end date</param>
        /// <remarks>For loading funds recurring monthly</remarks>
        /// <returns>Details of a transaction to add funds</returns>
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

        /// <summary>
        /// Withdraw funds from the investor's account
        /// </summary>
        /// <param name="amount">Amount of funds to withdraw</param>
        /// <returns>Details of a transaction to withdraw funds</returns>
        public Task<AccountWithdrawFunds> WithdrawFundsAsync(decimal amount)
        {
            return WithdrawFundsAsync(new { amount });
        }

        #endregion

        #region Cancel Transfer

        protected string CancelTransferUrl => $"{Url}/funds/cancel";

        private Task<AccountCancelTransfer> CancelTransferAsync<T>(T request)
        {
            return Client.PostAsync<AccountCancelTransfer, T>(CancelTransferUrl, request);
        }

        public Task<AccountCancelTransfer> CancelTransferAsync(IEnumerable<int> transferIds)
        {
            return CancelTransferAsync(transferIds.ToArray());
        }

        public Task<AccountCancelTransfer> CancelTransferAsync(params int[] transferIds)
        {
            return CancelTransferAsync(new
            {
                transferIds
            });
        }

        #endregion

    }
}
