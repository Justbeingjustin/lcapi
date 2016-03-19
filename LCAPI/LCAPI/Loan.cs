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
        /// Details of the loans currently listed on the Lending Club platform.
        /// The list contains the same loans that an investor would see on the browse loans page on the Lending Club website.
        /// </summary>
        /// <remarks>
        /// The same restrictions that Lending Club applies on the browse loans page also apply to the browse loans API.
        /// The API currently returns either the entire list of loans listed on the platform or only the loans listed in the recent listing period.
        /// Loans are listed on the Lending Club platform at 6AM, 10AM, 2PM, and 6PM every day.
        /// </remarks>
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
    }
}
