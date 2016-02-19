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
    public class ServicePlanVisibilitiesTest
    {


        [TestMethod]
        public void TestUpdateServicePlanVisibilityResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""4e189533-5c95-49a3-8a44-e71e15edca25"",
    ""url"": ""/v2/service_plan_visibilities/51f123b1-07ac-4f10-b36a-ec5b0d545c43"",
    ""created_at"": ""2016-02-11T13:20:50Z"",
    ""updated_at"": ""2016-02-11T13:20:50Z""
  },
  ""entity"": {
    ""service_plan_guid"": ""4e189533-5c95-49a3-8a44-e71e15edca25"",
    ""organization_guid"": ""4e189533-5c95-49a3-8a44-e71e15edca25"",
    ""service_plan_url"": ""/v2/service_plans/3caac295-ec23-4f8b-bb31-46dd2227b98c"",
    ""organization_url"": ""/v2/organizations/53489956-b857-4dc4-9ade-430d329fe44e""
  }
}";

            UpdateServicePlanVisibilityResponse obj = Utilities.DeserializeJson<UpdateServicePlanVisibilityResponse>(json);

            Assert.AreEqual("4e189533-5c95-49a3-8a44-e71e15edca25", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plan_visibilities/51f123b1-07ac-4f10-b36a-ec5b0d545c43", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:50Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:50Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("4e189533-5c95-49a3-8a44-e71e15edca25", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("4e189533-5c95-49a3-8a44-e71e15edca25", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("/v2/service_plans/3caac295-ec23-4f8b-bb31-46dd2227b98c", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/organizations/53489956-b857-4dc4-9ade-430d329fe44e", TestUtil.ToTestableString(obj.OrganizationUrl), true);
        }

        [TestMethod]
        public void TestListAllServicePlanVisibilitiesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""17943fc9-7e28-46f0-891c-9310cdbbb301"",
        ""url"": ""/v2/service_plan_visibilities/5fd21692-2515-4614-ad4d-b8ee01fac19c"",
        ""created_at"": ""2016-02-11T13:20:50Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""service_plan_guid"": ""17943fc9-7e28-46f0-891c-9310cdbbb301"",
        ""organization_guid"": ""17943fc9-7e28-46f0-891c-9310cdbbb301"",
        ""service_plan_url"": ""/v2/service_plans/15c53811-631c-43ee-a790-9f2a34b16ba6"",
        ""organization_url"": ""/v2/organizations/17cf9e15-258c-4397-8a26-ec58df332dcb""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicePlanVisibilitiesResponse> page = Utilities.DeserializePage<ListAllServicePlanVisibilitiesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("17943fc9-7e28-46f0-891c-9310cdbbb301", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plan_visibilities/5fd21692-2515-4614-ad4d-b8ee01fac19c", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:50Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("17943fc9-7e28-46f0-891c-9310cdbbb301", TestUtil.ToTestableString(page[0].ServicePlanGuid), true);
            Assert.AreEqual("17943fc9-7e28-46f0-891c-9310cdbbb301", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("/v2/service_plans/15c53811-631c-43ee-a790-9f2a34b16ba6", TestUtil.ToTestableString(page[0].ServicePlanUrl), true);
            Assert.AreEqual("/v2/organizations/17cf9e15-258c-4397-8a26-ec58df332dcb", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServicePlanVisibilityResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""0c993200-5157-4dc9-b6fb-24580c71b31f"",
    ""url"": ""/v2/service_plan_visibilities/c527632f-2b6f-4c0c-9385-a2a2d063cbb5"",
    ""created_at"": ""2016-02-11T13:20:51Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""service_plan_guid"": ""0c993200-5157-4dc9-b6fb-24580c71b31f"",
    ""organization_guid"": ""0c993200-5157-4dc9-b6fb-24580c71b31f"",
    ""service_plan_url"": ""/v2/service_plans/69ef01b9-dcb3-429f-a011-1ad0c4feff94"",
    ""organization_url"": ""/v2/organizations/b01d50bb-0058-4245-8610-060adfd71a60""
  }
}";

            RetrieveServicePlanVisibilityResponse obj = Utilities.DeserializeJson<RetrieveServicePlanVisibilityResponse>(json);

            Assert.AreEqual("0c993200-5157-4dc9-b6fb-24580c71b31f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plan_visibilities/c527632f-2b6f-4c0c-9385-a2a2d063cbb5", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:51Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("0c993200-5157-4dc9-b6fb-24580c71b31f", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("0c993200-5157-4dc9-b6fb-24580c71b31f", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("/v2/service_plans/69ef01b9-dcb3-429f-a011-1ad0c4feff94", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/organizations/b01d50bb-0058-4245-8610-060adfd71a60", TestUtil.ToTestableString(obj.OrganizationUrl), true);
        }

        [TestMethod]
        public void TestCreateServicePlanVisibilityResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""af2205b3-4910-4c45-a393-e4e0ff7ae74b"",
    ""url"": ""/v2/service_plan_visibilities/2e645444-bd88-4a83-bfb4-d0b818af89e1"",
    ""created_at"": ""2016-02-11T13:20:50Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""service_plan_guid"": ""af2205b3-4910-4c45-a393-e4e0ff7ae74b"",
    ""organization_guid"": ""af2205b3-4910-4c45-a393-e4e0ff7ae74b"",
    ""service_plan_url"": ""/v2/service_plans/eec243a3-b4c7-4fde-8fcb-cd0e92a2b05b"",
    ""organization_url"": ""/v2/organizations/fd1b457f-4c11-4bee-9ec5-25eef7390f35""
  }
}";

            CreateServicePlanVisibilityResponse obj = Utilities.DeserializeJson<CreateServicePlanVisibilityResponse>(json);

            Assert.AreEqual("af2205b3-4910-4c45-a393-e4e0ff7ae74b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plan_visibilities/2e645444-bd88-4a83-bfb4-d0b818af89e1", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:50Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("af2205b3-4910-4c45-a393-e4e0ff7ae74b", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("af2205b3-4910-4c45-a393-e4e0ff7ae74b", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("/v2/service_plans/eec243a3-b4c7-4fde-8fcb-cd0e92a2b05b", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/organizations/fd1b457f-4c11-4bee-9ec5-25eef7390f35", TestUtil.ToTestableString(obj.OrganizationUrl), true);
        }
    }
}
