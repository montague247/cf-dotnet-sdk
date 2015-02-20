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

using CloudFoundry.CloudController.V2.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ListAllServiceInstancesForServicePlanResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Credentials
        {
            get;
            set;
        }

        [JsonProperty("service_plan_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServicePlanGuid
        {
            get;
            set;
        }

        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        [JsonProperty("gateway_data", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic GatewayData
        {
            get;
            set;
        }

        [JsonProperty("dashboard_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DashboardUrl
        {
            get;
            set;
        }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }

        [JsonProperty("space_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceUrl
        {
            get;
            set;
        }

        [JsonProperty("service_plan_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlanUrl
        {
            get;
            set;
        }

        [JsonProperty("service_bindings_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceBindingsUrl
        {
            get;
            set;
        }
    }
}