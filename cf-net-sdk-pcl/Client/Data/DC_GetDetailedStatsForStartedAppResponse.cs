//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by cf-sdk-builder
// 

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using CloudFoundry.CloudController.V2.Interfaces;

namespace CloudFoundry.CloudController.V2.Client.Data
{
public class GetDetailedStatsForStartedAppResponse :IResponse
{

    public Metadata EntityMetadata
    {
    get;
    set;
    }



    [JsonProperty("state", NullValueHandling=NullValueHandling.Ignore)]
    public string State
    {
    get;
    set;
    }

    [JsonProperty("stats", NullValueHandling=NullValueHandling.Ignore)]
    public Dictionary<string, dynamic> Stats
    {
    get;
    set;
    }

}
}