using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicense_PCL.Abstractions
{
    public interface IDriverLicenseTicketsModel
    {
        [JsonProperty("answers")]
        string Answers { get; set; }

        [JsonProperty("coeficient")]
        string Coeficient { get; set; }

        [JsonProperty("correct_answer")]
        long CorrectAnswer { get; set; }

        [JsonProperty("cutoff")]
        long Cutoff { get; set; }

        [JsonProperty("desc")]
        string Desc { get; set; }

        [JsonProperty("file_parent")]
        long FileParent { get; set; }

        [JsonProperty("filename")]
        string Filename { get; set; }

        [JsonProperty("id")]
        int Id { get; set; }

        [JsonProperty("question")]
        string Question { get; set; }

        [JsonProperty("timestamp")]
        string Timestamp { get; set; }

        [JsonProperty("topic")]
        int Topic { get; set; }

        [JsonIgnore]
        List<string> TestAnswers { get; set; }

        [JsonIgnore]
        int ClickedOrNot { get; set; }

    }
}
