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
    public class BlobstoresTest
    {


        [TestMethod]
        public void TestDeleteAllBlobsInBuildpackCacheBlobstoreResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""908a5ff7-8254-4510-a7fd-9101b7a31843"",
    ""created_at"": ""2016-10-12T12:29:09Z"",
    ""url"": ""/v2/jobs/1eea6cc0-a76a-462e-a15a-e5dea01f9f1c""
  },
  ""entity"": {
    ""guid"": ""908a5ff7-8254-4510-a7fd-9101b7a31843"",
    ""status"": ""queued""
  }
}";

            DeleteAllBlobsInBuildpackCacheBlobstoreResponse obj = Utilities.DeserializeJson<DeleteAllBlobsInBuildpackCacheBlobstoreResponse>(json);

            Assert.AreEqual("908a5ff7-8254-4510-a7fd-9101b7a31843", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2016-10-12T12:29:09Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/1eea6cc0-a76a-462e-a15a-e5dea01f9f1c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("908a5ff7-8254-4510-a7fd-9101b7a31843", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);
        }
    }
}
