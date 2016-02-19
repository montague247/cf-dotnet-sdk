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

using CloudFoundry.CloudController.V3.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class AppRoutesExperimentalEndpoint
{
        [TestMethod]
        public void ListRoutesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""pagination"": {
    ""total_results"": 2,
    ""first"": {
      ""href"": ""/v3/apps/09381e34-521c-4d95-a3b6-c5b1a4a5e0f6/routes?page=1=50""
    },
    ""last"": {
      ""href"": ""/v3/apps/09381e34-521c-4d95-a3b6-c5b1a4a5e0f6/routes?page=1=50""
    },
    ""next"": null,
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""cc3cffe0-c750-4e49-8a9f-dc8d4708662b"",
      ""host"": ""host-6"",
      ""path"": """",
      ""created_at"": ""2016-02-11T13:20:32Z"",
      ""updated_at"": null,
      ""links"": {
        ""space"": {
          ""href"": ""/v2/spaces/9920bee5-ab70-4a63-8799-ee11a570bb4d""
        },
        ""domain"": {
          ""href"": ""/v2/domains/3f07f69d-9f3c-4893-b097-dc8634d5feb7""
        }
      }
    },
    {
      ""guid"": ""cc3cffe0-c750-4e49-8a9f-dc8d4708662b"",
      ""host"": ""host-7"",
      ""path"": ""/foo/bar"",
      ""created_at"": ""2016-02-11T13:20:32Z"",
      ""updated_at"": null,
      ""links"": {
        ""space"": {
          ""href"": ""/v2/spaces/9920bee5-ab70-4a63-8799-ee11a570bb4d""
        },
        ""domain"": {
          ""href"": ""/v2/domains/113857b5-715c-4511-b308-c3811aacbf83""
        }
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.AppRoutesExperimental.ListRoutes(guid).Result;

                Assert.AreEqual("cc3cffe0-c750-4e49-8a9f-dc8d4708662b", TestUtil.ToTestableString(obj[0].Guid), true);
                Assert.AreEqual("host-6", TestUtil.ToTestableString(obj[0].Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Path), true);
                Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(obj[0].CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].UpdatedAt), true);
                Assert.AreEqual("cc3cffe0-c750-4e49-8a9f-dc8d4708662b", TestUtil.ToTestableString(obj[1].Guid), true);
                Assert.AreEqual("host-7", TestUtil.ToTestableString(obj[1].Host), true);
                Assert.AreEqual("/foo/bar", TestUtil.ToTestableString(obj[1].Path), true);
                Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(obj[1].CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].UpdatedAt), true);

            }
        }

        [TestMethod]
        public void UnmapRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UnmapRouteRequest value = new UnmapRouteRequest();


                cfClient.AppRoutesExperimental.UnmapRoute(guid, value).Wait();

            }
        }

        [TestMethod]
        public void MapRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                MapRouteRequest value = new MapRouteRequest();


                cfClient.AppRoutesExperimental.MapRoute(guid, value).Wait();

            }
        }

    }
}