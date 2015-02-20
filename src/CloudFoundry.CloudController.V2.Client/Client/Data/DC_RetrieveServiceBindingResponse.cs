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
    public class RetrieveServiceBindingResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("app_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AppGuid
        {
            get;
            set;
        }

        [JsonProperty("service_instance_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceInstanceGuid
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

        [JsonProperty("binding_options", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<dynamic, dynamic> BindingOptions
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

        [JsonProperty("gateway_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayName
        {
            get;
            set;
        }

        [JsonProperty("syslog_drain_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic SyslogDrainUrl
        {
            get;
            set;
        }

        [JsonProperty("app_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppUrl
        {
            get;
            set;
        }

        [JsonProperty("service_instance_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceInstanceUrl
        {
            get;
            set;
        }
    }
}