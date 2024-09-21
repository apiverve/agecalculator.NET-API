using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("dob")]
    public string dob { get; set; }

    [JsonProperty("age_years")]
    public int ageyears { get; set; }

    [JsonProperty("age_months")]
    public int agemonths { get; set; }

    [JsonProperty("age_weeks")]
    public int ageweeks { get; set; }

    [JsonProperty("age_days")]
    public int agedays { get; set; }

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
