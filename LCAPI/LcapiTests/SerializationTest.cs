using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LendingClub.Models;
using Xunit;
using LCAPI.Extensions;
using LCAPI.JSON;
using LCAPI.REST;

namespace LcapiTests
{
    public class SerializationTest
    {
        private readonly IDeserializer _deserializer;
        private readonly ISerializer _serializer;

        public SerializationTest()
        {
            _deserializer = new JsonDeserializer();
            _serializer = new JsonSerializer();
        }

        [Fact]
        public void RoundTripSerializationTest()
        {
            var x = new AccountAddFunds
            {
                Amount = 5123.5125m,
                Frequency = TransferFrequency.LoadOnDay1And16,
                StartDate = DateTime.Parse("2/29/2016"),
                EndDate = DateTime.Parse("12/19/2017")
            };
            var str = _serializer.Serialize(x);
            var y = _deserializer.Deserialize<AccountAddFunds>(str);

            Assert.Equal(x.Amount, y.Amount);
            Assert.Equal(x.Frequency, y.Frequency);
            Assert.Equal(x.StartDate.Value.ToUniversalTime(), y.StartDate);
            Assert.Equal(x.EndDate.Value.ToUniversalTime(), y.EndDate);
        }
    }
}
