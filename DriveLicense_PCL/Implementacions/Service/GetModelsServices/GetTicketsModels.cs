using DriveLicense_PCL.Abstractions;
using DriveLicense_PCL.Abstractions.Service;
using DriveLicense_PCL.DTExchanger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveLicense_PCL.Extencions;
using System.IO;

namespace DriveLicense_PCL.Implementacions.Service
{
    public class GetTicketsModels : IGetTicketsModes
    {
        private DataExchanger dataExchanger = DataExchanger.Instance();
        private AnswerStringSpliter SpliterService = new AnswerStringSpliter();
        private string TicketsUrl => dataExchanger.TicketsURL;
        private string ImageFileURL = $"{Directory.GetCurrentDirectory()}/images/";
        private async Task<string> GetTicketsJsonDataAsync()
        {
            return await dataExchanger.GetJsonDataAsync(TicketsUrl);
        }

        public async Task<List<DriverLicenseTicketsModel>> GetTicketsDataAsync()
        {
            var TicketsData = await dataExchanger.GetTicketsData(await GetTicketsJsonDataAsync()).GetModelsWithImages(ImageFileURL);
            return SpliterService.StringSpliter(TicketsData);
        }
    }
}
