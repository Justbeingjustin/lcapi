using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingClub.Models
{
    public enum TransferFrequency
    {
        None,
        LoadNow,
        LoadOnce,
        LoadWeekly,
        LoadBiWeekly,
        LoadOnDay1And16,
        LoadMonthly
    }
}
