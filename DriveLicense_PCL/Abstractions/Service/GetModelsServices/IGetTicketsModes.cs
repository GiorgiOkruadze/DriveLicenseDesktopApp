using DriveLicense_PCL.Implementacions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Abstractions.Service
{
    interface IGetTicketsModes
    {
        Task<List<DriverLicenseTicketsModel>> GetTicketsDataAsync();
    }
}
