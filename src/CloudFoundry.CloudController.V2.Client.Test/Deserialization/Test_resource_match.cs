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
    public class ResourceMatchTest
    {


        [TestMethod]
        public void TestListAllMatchingResourcesResponse()
        {
            string json = @"[
  {
    ""sha1"": ""d3a0247f3850a007d8e34fbb67efae795aace953"",
    ""size"": 36
  }
]";

            ListAllMatchingResourcesResponse[] obj = Utilities.DeserializeJsonArray<ListAllMatchingResourcesResponse>(json);

            Assert.AreEqual("d3a0247f3850a007d8e34fbb67efae795aace953", TestUtil.ToTestableString(obj[0].Sha1), true);
            Assert.AreEqual("36", TestUtil.ToTestableString(obj[0].Size), true);
        }
    }
}
