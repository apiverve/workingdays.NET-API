using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class nonWorkingDays
{
    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("reasons")]
    public string[] reasons { get; set; }

    [JsonProperty("holiday_name")]
    public object holidayname { get; set; }

}

public class data
{
    [JsonProperty("workingDaysCount")]
    public int workingDaysCount { get; set; }

    [JsonProperty("nonWorkingDaysCount")]
    public int nonWorkingDaysCount { get; set; }

    [JsonProperty("workingDays")]
    public string[] workingDays { get; set; }

    [JsonProperty("nonWorkingDays")]
    public nonWorkingDays[] nonWorkingDays { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
