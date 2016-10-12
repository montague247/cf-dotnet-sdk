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

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SecurityGroupStagingDefaultsEndpoint
{
        [TestMethod]
        public void SetSecurityGroupAsDefaultForStagingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""f2d17574-1afa-42d0-adff-d76d4bb15351"",
    ""url"": ""/v2/config/staging_security_groups/a5021efc-b46c-4ff6-98be-2459b88f1a95"",
    ""created_at"": ""2016-10-12T12:29:20Z"",
    ""updated_at"": ""2016-10-12T12:29:20Z""
  },
  ""entity"": {
    ""name"": ""name-554"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": false,
    ""staging_default"": true
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroupStagingDefaults.SetSecurityGroupAsDefaultForStaging(guid).Result;


                Assert.AreEqual("f2d17574-1afa-42d0-adff-d76d4bb15351", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/config/staging_security_groups/a5021efc-b46c-4ff6-98be-2459b88f1a95", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:20Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-10-12T12:29:20Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-554", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.StagingDefault), true);

            }
        }

        [TestMethod]
        public void ReturnSecurityGroupsUsedForStagingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""147cf26d-8c1d-48aa-bfeb-09bc14479315"",
        ""url"": ""/v2/config/staging_security_groups/c75f29c7-a563-4dd5-8649-eeb488cfa33a"",
        ""created_at"": ""2016-10-12T12:29:20Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-553"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": true
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SecurityGroupStagingDefaults.ReturnSecurityGroupsUsedForStaging().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("147cf26d-8c1d-48aa-bfeb-09bc14479315", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/config/staging_security_groups/c75f29c7-a563-4dd5-8649-eeb488cfa33a", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:20Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-553", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].RunningDefault), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].StagingDefault), true);

            }
        }

        [TestMethod]
        public void RemovingSecurityGroupAsDefaultForStagingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SecurityGroupStagingDefaults.RemovingSecurityGroupAsDefaultForStaging(guid).Wait();

            }
        }

    }
}