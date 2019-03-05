using DriveLicense_PCL.Abstractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Implementacions
{
    public class DriverLicenseTicketsModel: IDriverLicenseTicketsModel
    {
        [JsonProperty("answers")]
        public string Answers { get; set; }

        [JsonProperty("coeficient")]
        public string Coeficient { get; set; }

        [JsonProperty("correct_answer")]
        public long CorrectAnswer { get; set; }

        [JsonProperty("cutoff")]
        public long Cutoff { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("file_parent")]
        public long FileParent { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("topic")]
        public int Topic { get; set; }

        public List<string> TestAnswers { get; set; }

        public int ClickedOrNot { get; set; } = -1;
    }
}
