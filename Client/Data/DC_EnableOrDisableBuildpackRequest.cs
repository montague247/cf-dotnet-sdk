using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using cf_net_sdk.Interfaces;

namespace cf_net_sdk.Client.Data
{
public class EnableOrDisableBuildpackRequest
{



    [JsonProperty("enabled", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic Enabled
    {
    get;
    set;
    }

    [JsonProperty("name", NullValueHandling=NullValueHandling.Ignore)]
    public string Name
    {
    get;
    set;
    }

    [JsonProperty("position", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic Position
    {
    get;
    set;
    }

    [JsonProperty("locked", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic Locked
    {
    get;
    set;
    }

    [JsonProperty("filename", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic Filename
    {
    get;
    set;
    }

}
}