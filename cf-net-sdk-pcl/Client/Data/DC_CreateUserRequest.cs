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
public class CreateUserRequest
{



    [JsonProperty("guid", NullValueHandling=NullValueHandling.Ignore)]
    public string Guid
    {
    get;
    set;
    }

    [JsonProperty("default_space_guid", NullValueHandling=NullValueHandling.Ignore)]
    public Guid? DefaultSpaceGuid
    {
    get;
    set;
    }

    [JsonProperty("admin", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic Admin
    {
    get;
    set;
    }

}
}