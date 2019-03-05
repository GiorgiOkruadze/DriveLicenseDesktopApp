using DriveLicense_PCL.Abstractions;
using DriveLicense_PCL.Abstractions.Service;
using DriveLicense_PCL.DTExchanger;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Implementacions.Service
{
    public class GetTopicsModels : IGetTopicsModels
    {
        private DataExchanger dataExchanger = DataExchanger.Instance();
        private string TopicsURL => dataExchanger.TopicsURL;
        private async Task<string> GetTopicsJsonDataAsync()
        {
            return await dataExchanger.GetJsonDataAsync(TopicsURL);
        }

        public async Task<List<DriverLicenseTopicsModel>> GetTopicsDataAsync()
        {
            return dataExchanger.GetTopicsData(await GetTopicsJsonDataAsync());
        }

    }
}
