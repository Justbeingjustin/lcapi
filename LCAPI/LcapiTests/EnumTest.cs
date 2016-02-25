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
        public void EnumParseTest(string stringValue, Enum enumValue)
        {
            var parsedValue = typeof (LoanPurpose).FindEnumValue(stringValue, CultureInfo.CurrentCulture);
            Assert.Equal(parsedValue, enumValue);
        }
    }
}
