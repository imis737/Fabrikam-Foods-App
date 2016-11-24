using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Fabrikam_Foods_App
{
    public class Bookings
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool deleted { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Number")]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "DateUtc")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "Time")]
        public TimeSpan Time { get; set; }

        //[JsonProperty("Id")]
        //public string Id { get; set; }

        //[Microsoft.WindowsAzure.MobileServices.Version]
        //public string AzureVersion { get; set; }

        //public string Name { get; set; }

        //public int Number { get; set; }

        //public string Email { get; set; }

        //public DateTime DateUtc { get; set; }

        //public TimeSpan Time { get; set; }
    }
}
