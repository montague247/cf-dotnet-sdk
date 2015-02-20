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

using System;
using System.CodeDom.Compiler;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class FilesEndpoint : BaseEndpoint
    {
        public FilesEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }

        /// <summary>
        /// Retrieve File
        /// </summary>

        public async Task RetrieveFile(Guid? app_guid, int? instance_index, dynamic file_path)
        {
            string route = string.Format("/v2/apps/{0}/instances/{1}/files/{2}", app_guid, instance_index, file_path);

            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;

            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());

            var response = await this.SendAsync(client);
        }
    }
}