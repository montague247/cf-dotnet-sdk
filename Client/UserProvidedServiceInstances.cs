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
public class UserProvidedServiceInstancesEndpoint: BaseEndpoint
{
public UserProvidedServiceInstancesEndpoint(CloudfoundryClient client)
{
this.CloudTarget = client.CloudTarget;
this.CancellationToken = client.CancellationToken;
this.ServiceLocator = client.ServiceLocator;
this.auth = client.auth;
}

    /// <summary>
  /// Creating a User Provided Service Instance
  /// </summary>
    public async Task<CreateUserProvidedServiceInstanceResponse> CreateUserProvidedServiceInstance(CreateUserProvidedServiceInstanceRequest value)
    {
        string route = "/v2/user_provided_service_instances/";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Post;
    client.Headers.Add(BuildAuthenticationHeader());
    
        client.ContentType = "application/x-www-form-urlencoded";
    
    
        client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<CreateUserProvidedServiceInstanceResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Delete a Particular User Provided Service Instance
  /// </summary>
    public async Task DeleteUserProvidedServiceInstance(Guid guid)
    {
        string route = string.Format("/v2/user_provided_service_instances/{0}", guid);
    
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
  /// List all Service Bindings for the User Provided Service Instance
  /// </summary>
    public async Task<ListAllServiceBindingsForUserProvidedServiceInstanceResponse[]> ListAllServiceBindingsForUserProvidedServiceInstance(Guid guid)
    {
        string route = string.Format("/v2/user_provided_service_instances/{0}/service_bindings", guid);
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJsonArray<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// List all User Provided Service Instances
  /// </summary>
    public async Task<ListAllUserProvidedServiceInstancesResponse[]> ListAllUserProvidedServiceInstances()
    {
        string route = "/v2/user_provided_service_instances";
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJsonArray<ListAllUserProvidedServiceInstancesResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Retrieve a Particular User Provided Service Instance
  /// </summary>
    public async Task<RetrieveUserProvidedServiceInstanceResponse> RetrieveUserProvidedServiceInstance(Guid guid)
    {
        string route = string.Format("/v2/user_provided_service_instances/{0}", guid);
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Get;
    client.Headers.Add(BuildAuthenticationHeader());
    
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<RetrieveUserProvidedServiceInstanceResponse>(await response.ReadContentAsStringAsync());
        
    
    }

    /// <summary>
  /// Updating a User Provided Service Instance
  /// </summary>
    public async Task<UpdateUserProvidedServiceInstanceResponse> UpdateUserProvidedServiceInstance(Guid guid, UpdateUserProvidedServiceInstanceRequest value)
    {
        string route = string.Format("/v2/user_provided_service_instances/{0}", guid);
    
    string endpoint = this.CloudTarget.Value.TrimEnd('/') + route;
    var client = this.GetHttpClient();
    client.Uri = new Uri(endpoint);

    client.Method = HttpMethod.Put;
    client.Headers.Add(BuildAuthenticationHeader());
    
        client.ContentType = "application/x-www-form-urlencoded";
    
    
        client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
    
    // TODO: vladi: Implement serialization

    var response = await client.SendAsync();
    
        
            return Util.DeserializeJson<UpdateUserProvidedServiceInstanceResponse>(await response.ReadContentAsStringAsync());
        
    
    }

}
}