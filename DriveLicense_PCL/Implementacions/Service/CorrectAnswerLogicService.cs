using DriveLicense_PCL.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Implementacions.Service
{
    public class CorrectAnswerLogicService : ICorrectAnswerLogicService
    {
        public int CorrectAnswerLogic(DriverLicenseTicketsModel Model, int Index)
        {
            if (Model.CorrectAnswer == Index+1)
                return 1;
            return 0;
        }
    }
}
