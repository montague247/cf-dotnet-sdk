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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceAuthTokensDeprecatedTest
    {


        [TestMethod]
        public void TestFilterResultSetByLabelDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""56168a70-6c5e-46e6-96a4-2ed44d571394"",
        ""url"": ""/v2/service_auth_tokens/24cb6341-efee-4801-bebe-91a48d4d3265"",
        ""created_at"": ""2016-07-07T09:17:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""Nic-Token"",
        ""provider"": ""provider-13""
      }
    }
  ]
}";

            PagedResponseCollection<FilterResultSetByLabelDeprecatedResponse> page = Utilities.DeserializePage<FilterResultSetByLabelDeprecatedResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("56168a70-6c5e-46e6-96a4-2ed44d571394", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/24cb6341-efee-4801-bebe-91a48d4d3265", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:17:18Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("Nic-Token", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("provider-13", TestUtil.ToTestableString(page[0].Provider), true);
        }

        [TestMethod]
        public void TestFilterResultSetByProviderDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""3a581036-946c-439b-8374-f30a6899832b"",
        ""url"": ""/v2/service_auth_tokens/d8509e4c-28fb-41a5-9b0d-35800db3939f"",
        ""created_at"": ""2016-07-07T09:17:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-90"",
        ""provider"": ""Face-Offer""
      }
    }
  ]
}";

            PagedResponseCollection<FilterResultSetByProviderDeprecatedResponse> page = Utilities.DeserializePage<FilterResultSetByProviderDeprecatedResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("3a581036-946c-439b-8374-f30a6899832b", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/d8509e4c-28fb-41a5-9b0d-35800db3939f", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:17:18Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-90", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("Face-Offer", TestUtil.ToTestableString(page[0].Provider), true);
        }

        [TestMethod]
        public void TestListAllServiceAuthTokensDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""65e45fb6-aead-4e89-8809-8404a582f912"",
        ""url"": ""/v2/service_auth_tokens/b8bbb0f6-18eb-4151-b121-33cc5a19840b"",
        ""created_at"": ""2016-07-07T09:17:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-94"",
        ""provider"": ""provider-14""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""65e45fb6-aead-4e89-8809-8404a582f912"",
        ""url"": ""/v2/service_auth_tokens/9bfdae26-4d96-4414-82e2-c7501bf1bb66"",
        ""created_at"": ""2016-07-07T09:17:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-95"",
        ""provider"": ""provider-15""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""65e45fb6-aead-4e89-8809-8404a582f912"",
        ""url"": ""/v2/service_auth_tokens/5ec75d3a-a578-4a9a-b5df-c7813c313415"",
        ""created_at"": ""2016-07-07T09:17:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-96"",
        ""provider"": ""provider-16""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceAuthTokensDeprecatedResponse> page = Utilities.DeserializePage<ListAllServiceAuthTokensDeprecatedResponse>(json, null);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("65e45fb6-aead-4e89-8809-8404a582f912", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/b8bbb0f6-18eb-4151-b121-33cc5a19840b", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:17:18Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-94", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("provider-14", TestUtil.ToTestableString(page[0].Provider), true);
            Assert.AreEqual("65e45fb6-aead-4e89-8809-8404a582f912", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/9bfdae26-4d96-4414-82e2-c7501bf1bb66", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:17:18Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-95", TestUtil.ToTestableString(page[1].Label), true);
            Assert.AreEqual("provider-15", TestUtil.ToTestableString(page[1].Provider), true);
            Assert.AreEqual("65e45fb6-aead-4e89-8809-8404a582f912", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/5ec75d3a-a578-4a9a-b5df-c7813c313415", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:17:18Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-96", TestUtil.ToTestableString(page[2].Label), true);
            Assert.AreEqual("provider-16", TestUtil.ToTestableString(page[2].Provider), true);
        }

        [TestMethod]
        public void TestRetrieveServiceAuthTokenDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""36156db2-e461-4e6e-9cca-e1253ef366b2"",
    ""url"": ""/v2/service_auth_tokens/f63577ba-2f31-47c9-bb85-751232195ac6"",
    ""created_at"": ""2016-07-07T09:17:18Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-84"",
    ""provider"": ""provider-4""
  }
}";

            RetrieveServiceAuthTokenDeprecatedResponse obj = Utilities.DeserializeJson<RetrieveServiceAuthTokenDeprecatedResponse>(json);

            Assert.AreEqual("36156db2-e461-4e6e-9cca-e1253ef366b2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/f63577ba-2f31-47c9-bb85-751232195ac6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:17:18Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-84", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("provider-4", TestUtil.ToTestableString(obj.Provider), true);
        }
    }
}