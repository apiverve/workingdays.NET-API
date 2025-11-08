using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// NonWorkingDays data
    /// </summary>
    public class NonWorkingDays
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("reasons")]
        public string[] Reasons { get; set; }

        [JsonProperty("holiday_name")]
        public object Holidayname { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("workingDaysCount")]
        public int WorkingDaysCount { get; set; }

        [JsonProperty("nonWorkingDaysCount")]
        public int NonWorkingDaysCount { get; set; }

        [JsonProperty("workingDays")]
        public string[] WorkingDays { get; set; }

        [JsonProperty("nonWorkingDays")]
        public NonWorkingDays[] NonWorkingDays { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
