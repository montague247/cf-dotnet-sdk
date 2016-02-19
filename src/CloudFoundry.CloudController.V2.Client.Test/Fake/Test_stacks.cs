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
    public class StacksEndpoint
{
        [TestMethod]
        public void DeleteStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.Stacks.DeleteStack(guid).Wait();

            }
        }

        [TestMethod]
        public void RetrieveStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""4e45be9f-ec3d-484f-b884-81fa58aa7c6b"",
    ""url"": ""/v2/stacks/1c69fd66-5c1d-433a-b422-cd23c124fc21"",
    ""created_at"": ""2016-02-11T13:20:54Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""cflinuxfs2"",
    ""description"": ""cflinuxfs2""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Stacks.RetrieveStack(guid).Result;


                Assert.AreEqual("4e45be9f-ec3d-484f-b884-81fa58aa7c6b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/1c69fd66-5c1d-433a-b422-cd23c124fc21", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:54Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Description), true);

            }
        }

        [TestMethod]
        public void ListAllStacksTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""494e8122-8535-442a-b5f5-1f55397bca94"",
        ""url"": ""/v2/stacks/1c69fd66-5c1d-433a-b422-cd23c124fc21"",
        ""created_at"": ""2016-02-11T13:20:54Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cflinuxfs2"",
        ""description"": ""cflinuxfs2""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""494e8122-8535-442a-b5f5-1f55397bca94"",
        ""url"": ""/v2/stacks/712a6475-422d-4326-9922-85382417e689"",
        ""created_at"": ""2016-02-11T13:20:54Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default-stack-name"",
        ""description"": ""default-stack-description""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""494e8122-8535-442a-b5f5-1f55397bca94"",
        ""url"": ""/v2/stacks/0fdf745f-3447-414c-9c58-0771d5888c89"",
        ""created_at"": ""2016-02-11T13:20:54Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cider"",
        ""description"": ""cider-description""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Stacks.ListAllStacks().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("494e8122-8535-442a-b5f5-1f55397bca94", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/1c69fd66-5c1d-433a-b422-cd23c124fc21", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:54Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("494e8122-8535-442a-b5f5-1f55397bca94", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/712a6475-422d-4326-9922-85382417e689", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:54Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("default-stack-name", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("default-stack-description", TestUtil.ToTestableString(obj[1].Description), true);
                Assert.AreEqual("494e8122-8535-442a-b5f5-1f55397bca94", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/0fdf745f-3447-414c-9c58-0771d5888c89", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:54Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cider", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("cider-description", TestUtil.ToTestableString(obj[2].Description), true);

            }
        }

        [TestMethod]
        public void CreateStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""fb708a12-b015-4d78-bdee-dc816c96a32e"",
    ""url"": ""/v2/stacks/afde9212-c712-4ed7-af2e-ee30e0d9a001"",
    ""created_at"": ""2016-02-11T13:20:58Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example_stack"",
    ""description"": ""Description for the example stack""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateStackRequest value = new CreateStackRequest();


                var obj = cfClient.Stacks.CreateStack(value).Result;


                Assert.AreEqual("fb708a12-b015-4d78-bdee-dc816c96a32e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/afde9212-c712-4ed7-af2e-ee30e0d9a001", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:58Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("example_stack", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("Description for the example stack", TestUtil.ToTestableString(obj.Description), true);

            }
        }

    }
}