using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Abstractions
{
    public interface IDriverLicenseTopicsModel
    {
        [JsonProperty("id")]
        long Id { get; set; }

        [JsonProperty("name")]
        string Name { get; set; }
    }
}
