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
    public class OrganizationQuotaDefinitionsTest
    {


        [TestMethod]
        public void TestUpdateOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""20df4cbe-6654-480f-b616-1720659799e7"",
    ""url"": ""/v2/quota_definitions/cfa34deb-eab8-457b-8ee7-7c8b4647092a"",
    ""created_at"": ""2016-02-11T13:20:39Z"",
    ""updated_at"": ""2016-02-11T13:20:39Z""
  },
  ""entity"": {
    ""name"": ""name-1478"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""total_private_domains"": -1,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1
  }
}";

            UpdateOrganizationQuotaDefinitionResponse obj = Utilities.DeserializeJson<UpdateOrganizationQuotaDefinitionResponse>(json);

            Assert.AreEqual("20df4cbe-6654-480f-b616-1720659799e7", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/cfa34deb-eab8-457b-8ee7-7c8b4647092a", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:39Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:39Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1478", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalPrivateDomains), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
        }

        [TestMethod]
        public void TestRetrieveOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""5ba28def-f72c-4406-af5e-3ecb7cdd1d4c"",
    ""url"": ""/v2/quota_definitions/e912658e-0a85-4f6d-b6ce-fe2e69b6d308"",
    ""created_at"": ""2016-02-11T13:20:39Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1480"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""total_private_domains"": -1,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1
  }
}";

            RetrieveOrganizationQuotaDefinitionResponse obj = Utilities.DeserializeJson<RetrieveOrganizationQuotaDefinitionResponse>(json);

            Assert.AreEqual("5ba28def-f72c-4406-af5e-3ecb7cdd1d4c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/e912658e-0a85-4f6d-b6ce-fe2e69b6d308", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:39Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1480", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalPrivateDomains), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
        }

        [TestMethod]
        public void TestCreateOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""96df4ddd-95f4-4f5d-8266-e8f057a6cda8"",
    ""url"": ""/v2/quota_definitions/142d4a10-7baa-449e-af95-0b16cdef38c4"",
    ""created_at"": ""2016-02-11T13:20:39Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""gold_quota"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 5,
    ""total_routes"": 10,
    ""total_private_domains"": -1,
    ""memory_limit"": 5120,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": 10240,
    ""app_instance_limit"": 10
  }
}";

            CreateOrganizationQuotaDefinitionResponse obj = Utilities.DeserializeJson<CreateOrganizationQuotaDefinitionResponse>(json);

            Assert.AreEqual("96df4ddd-95f4-4f5d-8266-e8f057a6cda8", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/142d4a10-7baa-449e-af95-0b16cdef38c4", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:39Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("gold_quota", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("10", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalPrivateDomains), true);
            Assert.AreEqual("5120", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("10240", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("10", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
        }

        [TestMethod]
        public void TestListAllOrganizationQuotaDefinitionsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""30f56b41-4591-4c23-916b-a38b794d85e0"",
        ""url"": ""/v2/quota_definitions/49e6300b-a9da-4947-bc14-7f0ac3fe62f4"",
        ""created_at"": ""2016-02-11T13:20:22Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default"",
        ""non_basic_services_allowed"": true,
        ""total_services"": 100,
        ""total_routes"": 1000,
        ""total_private_domains"": -1,
        ""memory_limit"": 10240,
        ""trial_db_allowed"": false,
        ""instance_memory_limit"": -1,
        ""app_instance_limit"": -1
      }
    }
  ]
}";

            PagedResponseCollection<ListAllOrganizationQuotaDefinitionsResponse> page = Utilities.DeserializePage<ListAllOrganizationQuotaDefinitionsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("30f56b41-4591-4c23-916b-a38b794d85e0", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/49e6300b-a9da-4947-bc14-7f0ac3fe62f4", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:22Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("default", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].NonBasicServicesAllowed), true);
            Assert.AreEqual("100", TestUtil.ToTestableString(page[0].TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(page[0].TotalRoutes), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].TotalPrivateDomains), true);
            Assert.AreEqual("10240", TestUtil.ToTestableString(page[0].MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].AppInstanceLimit), true);
        }
    }
}
