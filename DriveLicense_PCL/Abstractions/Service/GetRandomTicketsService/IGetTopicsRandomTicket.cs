using DriveLicense_PCL.Implementacions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Abstractions.Service.GetRandomTicketsService
{
    interface IGetTopicsRandomTicket
    {
        Task<List<DriverLicenseTicketsModel>> GetRandomTickets(DriverLicenseTopicsModel Topic, List<DriverLicenseTicketsModel> Tickets);
        Task<List<DriverLicenseTicketsModel>> GetRandomTickets(List<DriverLicenseTopicsModel> Topic, List<DriverLicenseTicketsModel> Tickets);
    }
}
