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
    public class ServicePlansTest
    {


        [TestMethod]
        public void TestRetrieveServicePlanResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""da1b0b82-fc89-4555-8067-f9be02c29164"",
    ""url"": ""/v2/service_plans/e29f1663-a436-423b-bf31-c2e54bced1a5"",
    ""created_at"": ""2016-10-12T12:29:10Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-137"",
    ""free"": false,
    ""description"": ""desc-21"",
    ""service_guid"": ""da1b0b82-fc89-4555-8067-f9be02c29164"",
    ""extra"": null,
    ""unique_id"": ""f5236850-19d9-4119-aa67-27515a363d63"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/350a7f3e-3304-44fa-8d5b-bf612b6fe378"",
    ""service_instances_url"": ""/v2/service_plans/e29f1663-a436-423b-bf31-c2e54bced1a5/service_instances""
  }
}";

            RetrieveServicePlanResponse obj = Utilities.DeserializeJson<RetrieveServicePlanResponse>(json);

            Assert.AreEqual("da1b0b82-fc89-4555-8067-f9be02c29164", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/e29f1663-a436-423b-bf31-c2e54bced1a5", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-137", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Free), true);
            Assert.AreEqual("desc-21", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("da1b0b82-fc89-4555-8067-f9be02c29164", TestUtil.ToTestableString(obj.ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("f5236850-19d9-4119-aa67-27515a363d63", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("/v2/services/350a7f3e-3304-44fa-8d5b-bf612b6fe378", TestUtil.ToTestableString(obj.ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/e29f1663-a436-423b-bf31-c2e54bced1a5/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);
        }

        [TestMethod]
        public void TestListAllServicePlansResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""45978183-6590-4eb7-b740-1c29b09edcb4"",
        ""url"": ""/v2/service_plans/0e15685e-d77a-46bd-9b07-0f7f05d38439"",
        ""created_at"": ""2016-10-12T12:29:10Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-141"",
        ""free"": false,
        ""description"": ""desc-25"",
        ""service_guid"": ""45978183-6590-4eb7-b740-1c29b09edcb4"",
        ""extra"": null,
        ""unique_id"": ""d8b5eaa7-260d-412e-9cfe-23f5662465b5"",
        ""public"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/c4db8bda-78e4-4f0d-b568-9274d9f07d73"",
        ""service_instances_url"": ""/v2/service_plans/0e15685e-d77a-46bd-9b07-0f7f05d38439/service_instances""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicePlansResponse> page = Utilities.DeserializePage<ListAllServicePlansResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("45978183-6590-4eb7-b740-1c29b09edcb4", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/0e15685e-d77a-46bd-9b07-0f7f05d38439", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-141", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Free), true);
            Assert.AreEqual("desc-25", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("45978183-6590-4eb7-b740-1c29b09edcb4", TestUtil.ToTestableString(page[0].ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("d8b5eaa7-260d-412e-9cfe-23f5662465b5", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("/v2/services/c4db8bda-78e4-4f0d-b568-9274d9f07d73", TestUtil.ToTestableString(page[0].ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/0e15685e-d77a-46bd-9b07-0f7f05d38439/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceInstancesForServicePlanResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f5b3501c-648c-4fc9-b96b-d84a6cc20010"",
        ""url"": ""/v2/service_instances/97563c96-5138-4be7-b4dd-c414ea7a379e"",
        ""created_at"": ""2016-10-12T12:29:10Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-145"",
        ""credentials"": {
          ""creds-key-13"": ""creds-val-13""
        },
        ""service_plan_guid"": ""f5b3501c-648c-4fc9-b96b-d84a6cc20010"",
        ""space_guid"": ""f5b3501c-648c-4fc9-b96b-d84a6cc20010"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""last_operation"": null,
        ""tags"": [

        ],
        ""space_url"": ""/v2/spaces/41210a9a-0b8b-4f0d-8b73-ece21bf08fda"",
        ""service_plan_url"": ""/v2/service_plans/ee0b4ee4-8e00-44f6-9aa4-b706c9e26e7e"",
        ""service_bindings_url"": ""/v2/service_instances/97563c96-5138-4be7-b4dd-c414ea7a379e/service_bindings"",
        ""service_keys_url"": ""/v2/service_instances/97563c96-5138-4be7-b4dd-c414ea7a379e/service_keys"",
        ""routes_url"": ""/v2/service_instances/97563c96-5138-4be7-b4dd-c414ea7a379e/routes""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceInstancesForServicePlanResponse> page = Utilities.DeserializePage<ListAllServiceInstancesForServicePlanResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("f5b3501c-648c-4fc9-b96b-d84a6cc20010", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/97563c96-5138-4be7-b4dd-c414ea7a379e", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-145", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("f5b3501c-648c-4fc9-b96b-d84a6cc20010", TestUtil.ToTestableString(page[0].ServicePlanGuid), true);
            Assert.AreEqual("f5b3501c-648c-4fc9-b96b-d84a6cc20010", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].LastOperation), true);
            Assert.AreEqual("/v2/spaces/41210a9a-0b8b-4f0d-8b73-ece21bf08fda", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/ee0b4ee4-8e00-44f6-9aa4-b706c9e26e7e", TestUtil.ToTestableString(page[0].ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/97563c96-5138-4be7-b4dd-c414ea7a379e/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/97563c96-5138-4be7-b4dd-c414ea7a379e/service_keys", TestUtil.ToTestableString(page[0].ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/97563c96-5138-4be7-b4dd-c414ea7a379e/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
        }

        [TestMethod]
        public void TestUpdateServicePlanResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""39837760-8d92-498d-804e-2a08557dadfb"",
    ""url"": ""/v2/service_plans/ad0812b4-e480-4d6f-a5b4-50daa7a3be98"",
    ""created_at"": ""2016-10-12T12:29:10Z"",
    ""updated_at"": ""2016-10-12T12:29:10Z""
  },
  ""entity"": {
    ""name"": ""name-139"",
    ""free"": false,
    ""description"": ""desc-23"",
    ""service_guid"": ""39837760-8d92-498d-804e-2a08557dadfb"",
    ""extra"": null,
    ""unique_id"": ""f31658e3-c52d-4533-913a-d04a5d84288c"",
    ""public"": false,
    ""active"": true,
    ""service_url"": ""/v2/services/0d8ff43f-bbb6-4a3c-b060-e16e9d9081ea"",
    ""service_instances_url"": ""/v2/service_plans/ad0812b4-e480-4d6f-a5b4-50daa7a3be98/service_instances""
  }
}";

            UpdateServicePlanResponse obj = Utilities.DeserializeJson<UpdateServicePlanResponse>(json);

            Assert.AreEqual("39837760-8d92-498d-804e-2a08557dadfb", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/ad0812b4-e480-4d6f-a5b4-50daa7a3be98", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-139", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Free), true);
            Assert.AreEqual("desc-23", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("39837760-8d92-498d-804e-2a08557dadfb", TestUtil.ToTestableString(obj.ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("f31658e3-c52d-4533-913a-d04a5d84288c", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("/v2/services/0d8ff43f-bbb6-4a3c-b060-e16e9d9081ea", TestUtil.ToTestableString(obj.ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/ad0812b4-e480-4d6f-a5b4-50daa7a3be98/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);
        }
    }
}
