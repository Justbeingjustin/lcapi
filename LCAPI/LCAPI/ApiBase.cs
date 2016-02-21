using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LendingClub
{
    public abstract class ApiBase
    {
        public static string Version { get; } = "v1";
        public static string BaseUrl { get; } = $"https://api.lendingclub.com/api/investor/{Version}";
    }
}
