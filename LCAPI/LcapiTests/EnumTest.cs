using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LendingClub.Models;
using Xunit;
using LCAPI.Extensions;

namespace LcapiTests
{
    public class EnumTest
    {
        [Theory]
        [InlineData("debt_consolidation", LoanPurpose.DebtConsolidation)]
        [InlineData("debtconsolidation", LoanPurpose.DebtConsolidation)]
        [InlineData("debtConsolidation", LoanPurpose.DebtConsolidation)]
        [InlineData("DebtConsolidation", LoanPurpose.DebtConsolidation)]
        [InlineData("medical", LoanPurpose.Medical)]
        [InlineData("home_improvement", LoanPurpose.HomeImprovement)]
        [InlineData("renewable_energy", LoanPurpose.RenewableEnergy)]
        [InlineData("small_business", LoanPurpose.SmallBusiness)]
        [InlineData("wedding", LoanPurpose.Wedding)]
        [InlineData("vacation", LoanPurpose.Vacation)]
        [InlineData("moving", LoanPurpose.Moving)]
        [InlineData("house", LoanPurpose.House)]
        [InlineData("car", LoanPurpose.Car)]
        [InlineData("major_purchase", LoanPurpose.MajorPurchase)]
        [InlineData("credit_card", LoanPurpose.CreditCard)]
        [InlineData("other", LoanPurpose.Other)]
        [InlineData("LOAD_NOW", TransferRequestFrequency.LoadNow)]
        [InlineData("LOAD_ONCE", TransferRequestFrequency.LoadOnce)]
        [InlineData("LOAD_WEEKLY", TransferRequestFrequency.LoadWeekly)]
        [InlineData("LOAD_BIWEEKLY", TransferRequestFrequency.LoadBiWeekly)]
        [InlineData("LOAD_ON_DAY_1_AND_16", TransferRequestFrequency.LoadOnDay1And16)]
        [InlineData("LOAD_MONTHLY", TransferRequestFrequency.LoadMonthly)]
        public void EnumParseTest(string stringValue, Enum enumValue)
        {
            var parsedValue = enumValue.GetType().FindEnumValue(stringValue, CultureInfo.CurrentCulture);
            Assert.Equal(parsedValue, enumValue);
        }
    }
}
