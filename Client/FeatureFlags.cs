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
public class FeatureFlagsEndpoint: BaseEndpoint
{
public FeatureFlagsEndpoint(CloudfoundryClient client)
{
this.CloudTarget = client.CloudTarget;
this.CancellationToken = client.CancellationToken;
this.ServiceLocator = client.ServiceLocator;
this.auth = client.auth;
}

    /// <summary>
  /// Get all feature flags
  /// </summary>
    public async Task<GetAllFeatureFlagsResponse[]> GetAllFeatureFlags()
    {
        string route = "/v2/config/feature_flags";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJsonArray<GetAllFeatureFlagsResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Get the App Bits Upload feature flag
  /// </summary>
        /// When enabled, space developers can upload app bits. When disabled, only admin users can upload app bits
    public async Task<GetAppBitsUploadFeatureFlagResponse> GetAppBitsUploadFeatureFlag()
    {
        string route = "/v2/config/feature_flags/app_bits_upload";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<GetAppBitsUploadFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Get the App Scaling feature flag
  /// </summary>
        /// When enabled, space developers can perform scaling operations (i.e. change memory, disk or instances). When disabled, only admin users can perform scaling operations.
    public async Task<GetAppScalingFeatureFlagResponse> GetAppScalingFeatureFlag()
    {
        string route = "/v2/config/feature_flags/app_scaling";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<GetAppScalingFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Get the Private Domain Creation feature flag
  /// </summary>
        /// When enabled, an organization manager can create private domains for that organization. When disabled, only admin users can create private domains.
    public async Task<GetPrivateDomainCreationFeatureFlagResponse> GetPrivateDomainCreationFeatureFlag()
    {
        string route = "/v2/config/feature_flags/private_domain_creation";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<GetPrivateDomainCreationFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Get the Route Creation feature flag
  /// </summary>
        /// When enabled, a space developer can create routes in a space. When disabled, only admin users can create routes.
    public async Task<GetRouteCreationFeatureFlagResponse> GetRouteCreationFeatureFlag()
    {
        string route = "/v2/config/feature_flags/route_creation";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<GetRouteCreationFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Get the Service Instance Creation feature flag
  /// </summary>
        /// When enabled, a space developer can create service instances in a space. When disabled, only admin users can create service instances.
    public async Task<GetServiceInstanceCreationFeatureFlagResponse> GetServiceInstanceCreationFeatureFlag()
    {
        string route = "/v2/config/feature_flags/service_instance_creation";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<GetServiceInstanceCreationFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Get the User Org Creation feature flag
  /// </summary>
        /// When enabled, any user can create an organization via the API. When disabled, only admin users can create organizations via the API.
    public async Task<GetUserOrgCreationFeatureFlagResponse> GetUserOrgCreationFeatureFlag()
    {
        string route = "/v2/config/feature_flags/user_org_creation";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<GetUserOrgCreationFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Set a feature flag
  /// </summary>
    public async Task<SetFeatureFlagResponse> SetFeatureFlag(dynamic name, SetFeatureFlagRequest value)
    {
        string route = string.Format("/v2/config/feature_flags/{0}", name);
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Put;
    client.Headers.Add(BuildAuthenticationHeader());
    
        client.ContentType = "application/x-www-form-urlencoded";
    
    
        client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<SetFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        
    
    }

}
}