using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrikam_Foods_App
{
    public class Bookings
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public string Email { get; set; }

        public DateTime DateUtc { get; set; }

        public TimeSpan Time { get; set; }
    }
}
