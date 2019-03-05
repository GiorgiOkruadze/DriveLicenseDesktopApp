using DriveLicense_PCL.Abstractions;
using DriveLicense_PCL.Abstractions.Service.GetRandomTicketsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveLicense_PCL.Extencions;

namespace DriveLicense_PCL.Implementacions.Service.GetRandomTicketsService
{
    public class GetTopicsRandomTicket : IGetTopicsRandomTicket
    {
        public async Task<List<DriverLicenseTicketsModel>> GetRandomTickets(DriverLicenseTopicsModel Topic, List<DriverLicenseTicketsModel> Tickets)
        {
            var MyTickets = await Task<List<DriverLicenseTicketsModel>>.Run(()=> {
                return Tickets.Where(o => o.Topic == Topic.Id).ToList();
            });

            MyTickets.Shuffle();

            if (MyTickets.Count <= 30)
                return MyTickets;
            else
                return MyTickets.Take(30).ToList();

        }

        public async Task<List<DriverLicenseTicketsModel>> GetRandomTickets(List<DriverLicenseTopicsModel> Topics, List<DriverLicenseTicketsModel> Tickets)
        {
            double a = 30 / Topics.Count;
            var TicketsCountFromSingleTopic = (int)Math.Ceiling(a);
            List<DriverLicenseTicketsModel> SelectedTickets = new List<DriverLicenseTicketsModel>();
            await Task.Run(()=> {
                foreach (var item in Topics)
                {
                    List<DriverLicenseTicketsModel> TpTicket = Tickets.Where(o => o.Topic == item.Id).Take(TicketsCountFromSingleTopic).ToList();

                    SelectedTickets.AddRange(TpTicket);
                }
            });
            SelectedTickets.Shuffle();

            return SelectedTickets.Take(30).ToList();

        }
    }
}
