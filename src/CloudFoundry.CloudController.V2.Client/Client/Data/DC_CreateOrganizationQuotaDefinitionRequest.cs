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
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class CreateOrganizationQuotaDefinitionRequest
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("non_basic_services_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NonBasicServicesAllowed
        {
            get;
            set;
        }

        [JsonProperty("total_services", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalServices
        {
            get;
            set;
        }

        [JsonProperty("total_routes", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRoutes
        {
            get;
            set;
        }

        [JsonProperty("memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryLimit
        {
            get;
            set;
        }

        [JsonProperty("instance_memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceMemoryLimit
        {
            get;
            set;
        }

        [JsonProperty("trial_db_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic TrialDbAllowed
        {
            get;
            set;
        }
    }
}