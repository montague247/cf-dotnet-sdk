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
    public class ServiceInstancesTest
    {


        [TestMethod]
        public void TestBindingServiceInstanceToRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c53b5d33-4f7a-4085-a332-cfbe369bef13"",
    ""url"": ""/v2/service_instances/05c0fce9-3668-4e49-af6c-d34e8b472acb"",
    ""created_at"": ""2016-10-12T12:29:11Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-218"",
    ""credentials"": {
      ""creds-key-30"": ""creds-val-30""
    },
    ""service_plan_guid"": ""c53b5d33-4f7a-4085-a332-cfbe369bef13"",
    ""space_guid"": ""c53b5d33-4f7a-4085-a332-cfbe369bef13"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": null,
    ""tags"": [

    ],
    ""space_url"": ""/v2/spaces/49b2681b-2ae0-483b-8b20-8cbd515e07ee"",
    ""service_plan_url"": ""/v2/service_plans/3f47dba2-1fe3-4637-8092-64a85347735c"",
    ""service_bindings_url"": ""/v2/service_instances/05c0fce9-3668-4e49-af6c-d34e8b472acb/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/05c0fce9-3668-4e49-af6c-d34e8b472acb/service_keys"",
    ""routes_url"": ""/v2/service_instances/05c0fce9-3668-4e49-af6c-d34e8b472acb/routes""
  }
}";

            BindingServiceInstanceToRouteResponse obj = Utilities.DeserializeJson<BindingServiceInstanceToRouteResponse>(json);

            Assert.AreEqual("c53b5d33-4f7a-4085-a332-cfbe369bef13", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/05c0fce9-3668-4e49-af6c-d34e8b472acb", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:11Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-218", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("c53b5d33-4f7a-4085-a332-cfbe369bef13", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("c53b5d33-4f7a-4085-a332-cfbe369bef13", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LastOperation), true);
            Assert.AreEqual("/v2/spaces/49b2681b-2ae0-483b-8b20-8cbd515e07ee", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/3f47dba2-1fe3-4637-8092-64a85347735c", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/05c0fce9-3668-4e49-af6c-d34e8b472acb/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/05c0fce9-3668-4e49-af6c-d34e8b472acb/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/05c0fce9-3668-4e49-af6c-d34e8b472acb/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestRetrievingPermissionsOnServiceInstanceResponse()
        {
            string json = @"{
  ""manage"": true
}";

            RetrievingPermissionsOnServiceInstanceResponse obj = Utilities.DeserializeJson<RetrievingPermissionsOnServiceInstanceResponse>(json);

            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Manage), true);
        }

        [TestMethod]
        public void TestListAllRoutesForServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""97c2205c-cf80-4b16-a929-b034e7f9893f"",
        ""url"": ""/v2/routes/66209a6e-fb26-4366-b65f-4fc0e170e04d"",
        ""created_at"": ""2016-10-12T12:29:11Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""host"": ""host-5"",
        ""path"": """",
        ""domain_guid"": ""97c2205c-cf80-4b16-a929-b034e7f9893f"",
        ""space_guid"": ""97c2205c-cf80-4b16-a929-b034e7f9893f"",
        ""service_instance_guid"": ""97c2205c-cf80-4b16-a929-b034e7f9893f"",
        ""port"": null,
        ""domain_url"": ""/v2/private_domains/51604b42-a8fc-4a82-937c-a9f528add611"",
        ""space_url"": ""/v2/spaces/c385449a-27e8-4f3c-99c8-cbcbf8731638"",
        ""service_instance_url"": ""/v2/service_instances/2e84b421-e3b8-4642-8369-ff4cc137fb26"",
        ""apps_url"": ""/v2/routes/66209a6e-fb26-4366-b65f-4fc0e170e04d/apps"",
        ""route_mappings_url"": ""/v2/routes/66209a6e-fb26-4366-b65f-4fc0e170e04d/route_mappings""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllRoutesForServiceInstanceResponse> page = Utilities.DeserializePage<ListAllRoutesForServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("97c2205c-cf80-4b16-a929-b034e7f9893f", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/66209a6e-fb26-4366-b65f-4fc0e170e04d", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:11Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-5", TestUtil.ToTestableString(page[0].Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Path), true);
            Assert.AreEqual("97c2205c-cf80-4b16-a929-b034e7f9893f", TestUtil.ToTestableString(page[0].DomainGuid), true);
            Assert.AreEqual("97c2205c-cf80-4b16-a929-b034e7f9893f", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("97c2205c-cf80-4b16-a929-b034e7f9893f", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Port), true);
            Assert.AreEqual("/v2/private_domains/51604b42-a8fc-4a82-937c-a9f528add611", TestUtil.ToTestableString(page[0].DomainUrl), true);
            Assert.AreEqual("/v2/spaces/c385449a-27e8-4f3c-99c8-cbcbf8731638", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/service_instances/2e84b421-e3b8-4642-8369-ff4cc137fb26", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
            Assert.AreEqual("/v2/routes/66209a6e-fb26-4366-b65f-4fc0e170e04d/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/routes/66209a6e-fb26-4366-b65f-4fc0e170e04d/route_mappings", TestUtil.ToTestableString(page[0].RouteMappingsUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceInstancesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""0c94f04c-f077-4a49-9ea8-a58961fe463d"",
        ""url"": ""/v2/service_instances/befdd386-4624-49f6-acfd-0de432a521fb"",
        ""created_at"": ""2016-10-12T12:29:12Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-230"",
        ""credentials"": {
          ""creds-key-32"": ""creds-val-32""
        },
        ""service_plan_guid"": ""0c94f04c-f077-4a49-9ea8-a58961fe463d"",
        ""space_guid"": ""0c94f04c-f077-4a49-9ea8-a58961fe463d"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""last_operation"": {
          ""type"": ""create"",
          ""state"": ""succeeded"",
          ""description"": ""service broker-provided description"",
          ""updated_at"": ""2016-10-12T12:29:12Z"",
          ""created_at"": ""2016-10-12T12:29:12Z""
        },
        ""tags"": [
          ""accounting"",
          ""mongodb""
        ],
        ""space_url"": ""/v2/spaces/8cffe680-bc86-4bf7-9323-5fb84e8684ea"",
        ""service_plan_url"": ""/v2/service_plans/3af89806-db23-47dc-9693-b6d8249d08b2"",
        ""service_bindings_url"": ""/v2/service_instances/befdd386-4624-49f6-acfd-0de432a521fb/service_bindings"",
        ""service_keys_url"": ""/v2/service_instances/befdd386-4624-49f6-acfd-0de432a521fb/service_keys"",
        ""routes_url"": ""/v2/service_instances/befdd386-4624-49f6-acfd-0de432a521fb/routes""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceInstancesResponse> page = Utilities.DeserializePage<ListAllServiceInstancesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("0c94f04c-f077-4a49-9ea8-a58961fe463d", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/befdd386-4624-49f6-acfd-0de432a521fb", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:12Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-230", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("0c94f04c-f077-4a49-9ea8-a58961fe463d", TestUtil.ToTestableString(page[0].ServicePlanGuid), true);
            Assert.AreEqual("0c94f04c-f077-4a49-9ea8-a58961fe463d", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("/v2/spaces/8cffe680-bc86-4bf7-9323-5fb84e8684ea", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/3af89806-db23-47dc-9693-b6d8249d08b2", TestUtil.ToTestableString(page[0].ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/befdd386-4624-49f6-acfd-0de432a521fb/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/befdd386-4624-49f6-acfd-0de432a521fb/service_keys", TestUtil.ToTestableString(page[0].ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/befdd386-4624-49f6-acfd-0de432a521fb/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""cc38d7a6-d4b2-46a5-97ff-da745ceba8de"",
    ""url"": ""/v2/service_instances/37935786-deb0-4703-9adf-2746821f7f4a"",
    ""created_at"": ""2016-10-12T12:29:12Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-236"",
    ""credentials"": {
      ""creds-key-33"": ""creds-val-33""
    },
    ""service_plan_guid"": ""cc38d7a6-d4b2-46a5-97ff-da745ceba8de"",
    ""space_guid"": ""cc38d7a6-d4b2-46a5-97ff-da745ceba8de"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""create"",
      ""state"": ""succeeded"",
      ""description"": ""service broker-provided description"",
      ""updated_at"": ""2016-10-12T12:29:12Z"",
      ""created_at"": ""2016-10-12T12:29:12Z""
    },
    ""tags"": [
      ""accounting"",
      ""mongodb""
    ],
    ""space_url"": ""/v2/spaces/aa18dac9-b87f-4dec-99c2-8d0ba9734aa8"",
    ""service_plan_url"": ""/v2/service_plans/402da0f4-7d28-4e87-a185-4ea8e80f4be1"",
    ""service_bindings_url"": ""/v2/service_instances/37935786-deb0-4703-9adf-2746821f7f4a/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/37935786-deb0-4703-9adf-2746821f7f4a/service_keys"",
    ""routes_url"": ""/v2/service_instances/37935786-deb0-4703-9adf-2746821f7f4a/routes""
  }
}";

            RetrieveServiceInstanceResponse obj = Utilities.DeserializeJson<RetrieveServiceInstanceResponse>(json);

            Assert.AreEqual("cc38d7a6-d4b2-46a5-97ff-da745ceba8de", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/37935786-deb0-4703-9adf-2746821f7f4a", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:12Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-236", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("cc38d7a6-d4b2-46a5-97ff-da745ceba8de", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("cc38d7a6-d4b2-46a5-97ff-da745ceba8de", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/aa18dac9-b87f-4dec-99c2-8d0ba9734aa8", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/402da0f4-7d28-4e87-a185-4ea8e80f4be1", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/37935786-deb0-4703-9adf-2746821f7f4a/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/37935786-deb0-4703-9adf-2746821f7f4a/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/37935786-deb0-4703-9adf-2746821f7f4a/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""fbf31f60-6d5b-4f4d-82ca-4d91191f3b28"",
    ""url"": ""/v2/service_instances/f17e6736-7149-4935-802d-394aee25f503"",
    ""created_at"": ""2016-10-12T12:29:12Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-service-instance"",
    ""credentials"": {

    },
    ""service_plan_guid"": ""fbf31f60-6d5b-4f4d-82ca-4d91191f3b28"",
    ""space_guid"": ""fbf31f60-6d5b-4f4d-82ca-4d91191f3b28"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""create"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": null,
      ""created_at"": ""2016-10-12T12:29:12Z""
    },
    ""tags"": [
      ""accounting"",
      ""mongodb""
    ],
    ""space_url"": ""/v2/spaces/4b9a88a6-1345-4756-a2d0-6d0c22a0746e"",
    ""service_plan_url"": ""/v2/service_plans/f7081c20-b8a3-4d54-bb89-894f97ad4071"",
    ""service_bindings_url"": ""/v2/service_instances/f17e6736-7149-4935-802d-394aee25f503/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/f17e6736-7149-4935-802d-394aee25f503/service_keys"",
    ""routes_url"": ""/v2/service_instances/f17e6736-7149-4935-802d-394aee25f503/routes""
  }
}";

            CreateServiceInstanceResponse obj = Utilities.DeserializeJson<CreateServiceInstanceResponse>(json);

            Assert.AreEqual("fbf31f60-6d5b-4f4d-82ca-4d91191f3b28", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/f17e6736-7149-4935-802d-394aee25f503", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:12Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-service-instance", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("fbf31f60-6d5b-4f4d-82ca-4d91191f3b28", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("fbf31f60-6d5b-4f4d-82ca-4d91191f3b28", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/4b9a88a6-1345-4756-a2d0-6d0c22a0746e", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/f7081c20-b8a3-4d54-bb89-894f97ad4071", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/f17e6736-7149-4935-802d-394aee25f503/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/f17e6736-7149-4935-802d-394aee25f503/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/f17e6736-7149-4935-802d-394aee25f503/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceKeysForServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""1bd69aad-675b-480e-a845-aa9601e38316"",
        ""url"": ""/v2/service_keys/26f05d5b-6932-485e-8dec-151cd23fb98f"",
        ""created_at"": ""2016-10-12T12:29:11Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""a-service-key"",
        ""service_instance_guid"": ""1bd69aad-675b-480e-a845-aa9601e38316"",
        ""credentials"": {
          ""creds-key-28"": ""creds-val-28""
        },
        ""service_instance_url"": ""/v2/service_instances/81506df9-d4e1-4145-9c84-98f402da7968""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceKeysForServiceInstanceResponse> page = Utilities.DeserializePage<ListAllServiceKeysForServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("1bd69aad-675b-480e-a845-aa9601e38316", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_keys/26f05d5b-6932-485e-8dec-151cd23fb98f", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:11Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("a-service-key", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("1bd69aad-675b-480e-a845-aa9601e38316", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("/v2/service_instances/81506df9-d4e1-4145-9c84-98f402da7968", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestDeleteServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""979f9047-ab64-41a6-8efd-b8f30330b87b"",
    ""url"": ""/v2/service_instances/1537424a-0013-492c-b172-99a8fbdcf9fa"",
    ""created_at"": ""2016-10-12T12:29:12Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-258"",
    ""credentials"": {
      ""creds-key-36"": ""creds-val-36""
    },
    ""service_plan_guid"": ""979f9047-ab64-41a6-8efd-b8f30330b87b"",
    ""space_guid"": ""979f9047-ab64-41a6-8efd-b8f30330b87b"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""delete"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-10-12T12:29:12Z"",
      ""created_at"": ""2016-10-12T12:29:12Z""
    },
    ""tags"": [
      ""accounting"",
      ""mongodb""
    ],
    ""space_url"": ""/v2/spaces/5ec1b017-e2fd-4c58-95db-7899c7e382e3"",
    ""service_plan_url"": ""/v2/service_plans/c1b5d038-f07e-4c87-9dd5-d96cf4b7119a"",
    ""service_bindings_url"": ""/v2/service_instances/1537424a-0013-492c-b172-99a8fbdcf9fa/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/1537424a-0013-492c-b172-99a8fbdcf9fa/service_keys"",
    ""routes_url"": ""/v2/service_instances/1537424a-0013-492c-b172-99a8fbdcf9fa/routes""
  }
}";

            DeleteServiceInstanceResponse obj = Utilities.DeserializeJson<DeleteServiceInstanceResponse>(json);

            Assert.AreEqual("979f9047-ab64-41a6-8efd-b8f30330b87b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/1537424a-0013-492c-b172-99a8fbdcf9fa", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:12Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-258", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("979f9047-ab64-41a6-8efd-b8f30330b87b", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("979f9047-ab64-41a6-8efd-b8f30330b87b", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/5ec1b017-e2fd-4c58-95db-7899c7e382e3", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/c1b5d038-f07e-4c87-9dd5-d96cf4b7119a", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/1537424a-0013-492c-b172-99a8fbdcf9fa/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/1537424a-0013-492c-b172-99a8fbdcf9fa/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/1537424a-0013-492c-b172-99a8fbdcf9fa/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceBindingsForServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""6c988d1b-e4ab-44cd-9549-d0af25fd25d5"",
        ""url"": ""/v2/service_bindings/9302c67d-2b1e-4837-9307-43e5e2b5c28b"",
        ""created_at"": ""2016-10-12T12:29:11Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""6c988d1b-e4ab-44cd-9549-d0af25fd25d5"",
        ""service_instance_guid"": ""6c988d1b-e4ab-44cd-9549-d0af25fd25d5"",
        ""credentials"": {
          ""creds-key-26"": ""creds-val-26""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""volume_mounts"": [

        ],
        ""service_instance_url"": ""/v2/service_instances/1120832b-ca82-402c-9d7c-5bbdfb3cde25""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsForServiceInstanceResponse> page = Utilities.DeserializePage<ListAllServiceBindingsForServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("6c988d1b-e4ab-44cd-9549-d0af25fd25d5", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/9302c67d-2b1e-4837-9307-43e5e2b5c28b", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:11Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("6c988d1b-e4ab-44cd-9549-d0af25fd25d5", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("6c988d1b-e4ab-44cd-9549-d0af25fd25d5", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/service_instances/1120832b-ca82-402c-9d7c-5bbdfb3cde25", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestUpdateServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""aece7689-7498-4130-8530-f74cbae5c572"",
    ""url"": ""/v2/service_instances/13462189-c676-4087-95f5-d7038de8673f"",
    ""created_at"": ""2016-10-12T12:29:12Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-242"",
    ""credentials"": {
      ""creds-key-34"": ""creds-val-34""
    },
    ""service_plan_guid"": ""aece7689-7498-4130-8530-f74cbae5c572"",
    ""space_guid"": ""aece7689-7498-4130-8530-f74cbae5c572"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""update"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-10-12T12:29:12Z"",
      ""created_at"": ""2016-10-12T12:29:12Z""
    },
    ""tags"": [

    ],
    ""space_url"": ""/v2/spaces/5cc19b88-125b-4a1b-97c1-73ed44db575c"",
    ""service_plan_url"": ""/v2/service_plans/4cbba62d-1980-435a-a76d-849718caff6c"",
    ""service_bindings_url"": ""/v2/service_instances/13462189-c676-4087-95f5-d7038de8673f/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/13462189-c676-4087-95f5-d7038de8673f/service_keys"",
    ""routes_url"": ""/v2/service_instances/13462189-c676-4087-95f5-d7038de8673f/routes""
  }
}";

            UpdateServiceInstanceResponse obj = Utilities.DeserializeJson<UpdateServiceInstanceResponse>(json);

            Assert.AreEqual("aece7689-7498-4130-8530-f74cbae5c572", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/13462189-c676-4087-95f5-d7038de8673f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:12Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-242", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("aece7689-7498-4130-8530-f74cbae5c572", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("aece7689-7498-4130-8530-f74cbae5c572", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/5cc19b88-125b-4a1b-97c1-73ed44db575c", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/4cbba62d-1980-435a-a76d-849718caff6c", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/13462189-c676-4087-95f5-d7038de8673f/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/13462189-c676-4087-95f5-d7038de8673f/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/13462189-c676-4087-95f5-d7038de8673f/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }
    }
}
