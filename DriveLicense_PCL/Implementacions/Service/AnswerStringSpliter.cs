using DriveLicense_PCL.Abstractions;
using DriveLicense_PCL.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Implementacions.Service
{
    public class AnswerStringSpliter:IAnswerStringSpliter
    {
        public List<DriverLicenseTicketsModel> StringSpliter(List<DriverLicenseTicketsModel> Data)
        {
            foreach (var item in Data)
            {
                var NewString = item.Answers.Split('\"');
                List<string> NewList = new List<string>();
                for (var i = 0; i < NewString.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        NewList.Add(NewString[i]);
                    }
                }
                item.TestAnswers = NewList;
            }
            return Data;
        }
    }
}
