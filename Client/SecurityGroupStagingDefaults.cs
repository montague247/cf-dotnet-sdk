using cf_net_sdk.Client.Data;
using cf_net_sdk.Interfaces;
using CloudFoundry.Common;
using CloudFoundry.Common.ServiceLocation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;

namespace cf_net_sdk.Client
{
public class SecurityGroupStagingDefaultsEndpoint: BaseEndpoint
{
public SecurityGroupStagingDefaultsEndpoint(CloudfoundryClient client)
{
this.CloudTarget = client.CloudTarget;
this.CancellationToken = client.CancellationToken;
this.ServiceLocator = client.ServiceLocator;
this.auth = client.auth;
}

    /// <summary>
  /// Removing a Security Group as a default for staging
  /// </summary>
    public async Task RemovingSecurityGroupAsDefaultForStaging(Guid guid)
    {
        string route = string.Format("/v2/config/staging_security_groups/{0}", guid);
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Delete;
    client.Headers.Add(BuildAuthenticationHeader());
    
        client.ContentType = "application/x-www-form-urlencoded";
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
    }

    /// <summary>
  /// Return the Security Groups used for staging
  /// </summary>
    public async Task<ReturnSecurityGroupsUsedForStagingResponse[]> ReturnSecurityGroupsUsedForStaging()
    {
        string route = "/v2/config/staging_security_groups";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJsonArray<ReturnSecurityGroupsUsedForStagingResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Set a Security Group as a default for staging
  /// </summary>
    public async Task<SetSecurityGroupAsDefaultForStagingResponse> SetSecurityGroupAsDefaultForStaging(Guid guid)
    {
        string route = string.Format("/v2/config/staging_security_groups/{0}", guid);
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Put;
    client.Headers.Add(BuildAuthenticationHeader());
    
        client.ContentType = "application/x-www-form-urlencoded";
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<SetSecurityGroupAsDefaultForStagingResponse>(await response.ReadContentAsStringAsync());
        
    
    }

}
}