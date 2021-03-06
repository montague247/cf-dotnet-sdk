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
    public class AppUsageEventsEndpoint
{
        [TestMethod]
        public void RetrieveAppUsageEventTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""61af30e1-3d9b-412e-8521-9ef675743c64"",
    ""url"": ""/v2/app_usage_events/68409532-4fe4-4337-a473-3ee4d8a9b3ce"",
    ""created_at"": ""2017-01-04T15:58:53Z""
  },
  ""entity"": {
    ""state"": ""STARTED"",
    ""previous_state"": null,
    ""memory_in_mb_per_instance"": 564,
    ""previous_memory_in_mb_per_instance"": null,
    ""instance_count"": 1,
    ""previous_instance_count"": null,
    ""app_guid"": ""61af30e1-3d9b-412e-8521-9ef675743c64"",
    ""app_name"": ""name-1827"",
    ""space_guid"": ""61af30e1-3d9b-412e-8521-9ef675743c64"",
    ""space_name"": ""name-1828"",
    ""org_guid"": ""61af30e1-3d9b-412e-8521-9ef675743c64"",
    ""buildpack_guid"": ""61af30e1-3d9b-412e-8521-9ef675743c64"",
    ""buildpack_name"": ""name-1829"",
    ""package_state"": ""STAGED"",
    ""previous_package_state"": null,
    ""parent_app_guid"": null,
    ""parent_app_name"": null,
    ""process_type"": ""web"",
    ""task_name"": null,
    ""task_guid"": null
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.AppUsageEvents.RetrieveAppUsageEvent(guid).Result;


                Assert.AreEqual("61af30e1-3d9b-412e-8521-9ef675743c64", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/app_usage_events/68409532-4fe4-4337-a473-3ee4d8a9b3ce", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("STARTED", TestUtil.ToTestableString(obj.State), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.PreviousState), true);
                Assert.AreEqual("564", TestUtil.ToTestableString(obj.MemoryInMbPerInstance), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.PreviousMemoryInMbPerInstance), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.InstanceCount), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.PreviousInstanceCount), true);
                Assert.AreEqual("61af30e1-3d9b-412e-8521-9ef675743c64", TestUtil.ToTestableString(obj.AppGuid), true);
                Assert.AreEqual("name-1827", TestUtil.ToTestableString(obj.AppName), true);
                Assert.AreEqual("61af30e1-3d9b-412e-8521-9ef675743c64", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("name-1828", TestUtil.ToTestableString(obj.SpaceName), true);
                Assert.AreEqual("61af30e1-3d9b-412e-8521-9ef675743c64", TestUtil.ToTestableString(obj.OrgGuid), true);
                Assert.AreEqual("61af30e1-3d9b-412e-8521-9ef675743c64", TestUtil.ToTestableString(obj.BuildpackGuid), true);
                Assert.AreEqual("name-1829", TestUtil.ToTestableString(obj.BuildpackName), true);
                Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj.PackageState), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.PreviousPackageState), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ParentAppGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ParentAppName), true);
                Assert.AreEqual("web", TestUtil.ToTestableString(obj.ProcessType), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.TaskName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.TaskGuid), true);

            }
        }

        [TestMethod]
        public void PurgeAndReseedAppUsageEventsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();


                cfClient.AppUsageEvents.PurgeAndReseedAppUsageEvents().Wait();

            }
        }

        [TestMethod]
        public void ListAllAppUsageEventsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 2,
  ""total_pages"": 2,
  ""prev_url"": null,
  ""next_url"": ""/v2/app_usage_events?after_guid=da4df871-1929-474d-97b6-85a00effaf9c=asc=2=1"",
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""2e3830f5-47d9-4fcf-80ca-281135a7755c"",
        ""url"": ""/v2/app_usage_events/9a85899c-88ec-4206-b42b-3aeb74fb706a"",
        ""created_at"": ""2017-01-04T15:58:52Z""
      },
      ""entity"": {
        ""state"": ""STARTED"",
        ""previous_state"": null,
        ""memory_in_mb_per_instance"": 564,
        ""previous_memory_in_mb_per_instance"": null,
        ""instance_count"": 1,
        ""previous_instance_count"": null,
        ""app_guid"": ""2e3830f5-47d9-4fcf-80ca-281135a7755c"",
        ""app_name"": ""name-1821"",
        ""space_guid"": ""2e3830f5-47d9-4fcf-80ca-281135a7755c"",
        ""space_name"": ""name-1822"",
        ""org_guid"": ""2e3830f5-47d9-4fcf-80ca-281135a7755c"",
        ""buildpack_guid"": ""2e3830f5-47d9-4fcf-80ca-281135a7755c"",
        ""buildpack_name"": ""name-1823"",
        ""package_state"": ""STAGED"",
        ""previous_package_state"": null,
        ""parent_app_guid"": null,
        ""parent_app_name"": null,
        ""process_type"": ""web"",
        ""task_name"": null,
        ""task_guid"": null
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.AppUsageEvents.ListAllAppUsageEvents().Result;

                Assert.AreEqual("2", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("2", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("/v2/app_usage_events?after_guid=da4df871-1929-474d-97b6-85a00effaf9c=asc=2=1", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("2e3830f5-47d9-4fcf-80ca-281135a7755c", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/app_usage_events/9a85899c-88ec-4206-b42b-3aeb74fb706a", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:52Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("STARTED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].PreviousState), true);
                Assert.AreEqual("564", TestUtil.ToTestableString(obj[0].MemoryInMbPerInstance), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].PreviousMemoryInMbPerInstance), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[0].InstanceCount), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].PreviousInstanceCount), true);
                Assert.AreEqual("2e3830f5-47d9-4fcf-80ca-281135a7755c", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("name-1821", TestUtil.ToTestableString(obj[0].AppName), true);
                Assert.AreEqual("2e3830f5-47d9-4fcf-80ca-281135a7755c", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("name-1822", TestUtil.ToTestableString(obj[0].SpaceName), true);
                Assert.AreEqual("2e3830f5-47d9-4fcf-80ca-281135a7755c", TestUtil.ToTestableString(obj[0].OrgGuid), true);
                Assert.AreEqual("2e3830f5-47d9-4fcf-80ca-281135a7755c", TestUtil.ToTestableString(obj[0].BuildpackGuid), true);
                Assert.AreEqual("name-1823", TestUtil.ToTestableString(obj[0].BuildpackName), true);
                Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj[0].PackageState), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].PreviousPackageState), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].ParentAppGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].ParentAppName), true);
                Assert.AreEqual("web", TestUtil.ToTestableString(obj[0].ProcessType), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].TaskName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].TaskGuid), true);

            }
        }

    }
}