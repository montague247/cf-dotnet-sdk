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
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class CreateSpaceRequest
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }

        [JsonProperty("developer_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DeveloperGuids
        {
            get;
            set;
        }

        [JsonProperty("manager_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ManagerGuids
        {
            get;
            set;
        }

        [JsonProperty("auditor_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic AuditorGuids
        {
            get;
            set;
        }

        [JsonProperty("domain_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DomainGuids
        {
            get;
            set;
        }

        [JsonProperty("security_group_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic SecurityGroupGuids
        {
            get;
            set;
        }

        [JsonProperty("space_quota_definition_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceQuotaDefinitionGuid
        {
            get;
            set;
        }
    }
}