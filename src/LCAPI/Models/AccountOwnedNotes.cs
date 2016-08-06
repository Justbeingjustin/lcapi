using System;
using System.Collections;
using System.Collections.Generic;
using LCAPI.JSON;

namespace LendingClub.Models
{
    /// <summary>
    /// List of notes that are owned by the investor
    /// </summary>
    public class AccountOwnedNotes : IReadOnlyList<Note>
    {
        [DeserializeAs("myNotes")]
        private List<Note> MyNotes { get; set; }

        public IEnumerator<Note> GetEnumerator() => MyNotes.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)MyNotes).GetEnumerator();

        public int Count => MyNotes.Count;

        public Note this[int index] => MyNotes[index];
    }
}
