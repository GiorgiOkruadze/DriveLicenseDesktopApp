using DriveLicense_PCL.Abstractions;
using DriveLicense_PCL.Implementacions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.DTExchanger
{
    public class DataExchanger
    {
        private static DataExchanger dataExchanger;
        private static object root = new object();
        private DataExchanger() { }

        public static DataExchanger Instance()
        {
            if (dataExchanger == null)
            {
                lock (root)
                {
                    if (dataExchanger == null)
                    {
                        dataExchanger = new DataExchanger();
                    }
                }
            }
            return dataExchanger;
        }

        public string TicketsURL => "tickets.json";
        public string TopicsURL => "topics.json";

        public async Task<string> GetJsonDataAsync(string url)
        {
            string JsonData;
            using (StreamReader str = new StreamReader(url))
            {
                JsonData = await str.ReadToEndAsync();
            }
            return JsonData;
        }

        public List<DriverLicenseTopicsModel> GetTopicsData(string JsonData)
        {
            var Data = JsonConvert.DeserializeObject<List<DriverLicenseTopicsModel>>(JsonData);

            return Data;
        }

        public List<DriverLicenseTicketsModel> GetTicketsData(string JsonData)
        {
            var Data = JsonConvert.DeserializeObject<List<DriverLicenseTicketsModel>>(JsonData);

            return Data;
        }

    }
}
