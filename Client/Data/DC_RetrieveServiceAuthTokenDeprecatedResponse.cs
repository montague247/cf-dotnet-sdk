using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using cf_net_sdk.Interfaces;

namespace cf_net_sdk.Client.Data
{
public class RetrieveServiceAuthTokenDeprecatedResponse :IResponse
{

    public Metadata EntityMetadata
    {
    get;
    set;
    }



    [JsonProperty("label", NullValueHandling=NullValueHandling.Ignore)]
    public string Label
    {
    get;
    set;
    }

    [JsonProperty("provider", NullValueHandling=NullValueHandling.Ignore)]
    public string Provider
    {
    get;
    set;
    }

}
}