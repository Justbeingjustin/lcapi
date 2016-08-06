using System;
using System.Collections;
using System.Collections.Generic;
using LCAPI.JSON;

namespace LendingClub.Models
{
    /// <summary>
    /// Pending fund transfers for the investor's account
    /// </summary>
    public class AccountPendingTransfers : IReadOnlyList<PendingFundsTransfer>
    {
        [DeserializeAs("transfers")]
        private List<PendingFundsTransfer> Transfers { get; set; }

        public IEnumerator<PendingFundsTransfer> GetEnumerator() => Transfers.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) Transfers).GetEnumerator();

        public int Count => Transfers.Count;

        public PendingFundsTransfer this[int index] => Transfers[index];
    }
}
