using System.Threading.Tasks;
using LCAPI.JSON;
using LCAPI.REST;
using LendingClub.Models;

namespace LendingClub
{
    public class Loan : ApiBase
    {
        public string Url => $"{BaseUrl}/loans";
        
        public Loan(string apiKey) : base(apiKey)
        {
        }

        protected string ListingUrl => $"{Url}/listing";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="showAll">
        /// <para>
        /// An optional parameter that defines the contents of the result.<br/>
        /// <br/>
        /// true - Results will contain all the loans listed on the platform<br/>
        /// false or absent - Results will contain only the loans listed in the most recent listing period.
        ///   If the listing is currently in progress, it will return the loans that have been listed so far.
        /// </para>
        /// </param>
        /// <returns></returns>
        public Task<LoanListing> GetListingAsync(bool showAll = false)
        {
            return Client.GetAsync<LoanListing>(ListingUrl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="showAll">
        /// <para>
        /// An optional parameter that defines the contents of the result.<br/>
        /// <br/>
        /// true - Results will contain all the loans listed on the platform<br/>
        /// false or absent - Results will contain only the loans listed in the most recent listing period.
        ///   If the listing is currently in progress, it will return the loans that have been listed so far.
        /// </para>
        /// </param>
        /// <returns></returns>
        public LoanListing GetListing(bool showAll = false)
        {
            return GetListingAsync(showAll).Result;
        }
    }
}
