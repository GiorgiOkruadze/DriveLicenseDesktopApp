using DriveLicense_PCL.Implementacions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Abstractions.Service
{
    public interface ICorrectAnswerLogicService
    {
        int CorrectAnswerLogic(DriverLicenseTicketsModel Model, int Index);
    }
}
