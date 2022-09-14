/*
 * Manticore Search Client
 *
 * Low-level client for Manticore Search. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@manticoresearch.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Net.Http;
using Xunit;

using ManticoreSearch.Client;
using ManticoreSearch.Api;
// uncomment below to import models
using ManticoreSearch.Model;

namespace ManticoreSearch.Test.Api
{
    /// <summary>
    ///  Class for testing IndexApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IndexApiTests : IDisposable
    {
        private IndexApi instance;

        public IndexApiTests()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:9308";
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            instance = new IndexApi(httpClient, config, httpClientHandler);
            var utilsApi = new UtilsApi();
            string body ="DROP TABLE IF EXISTS test";
            utilsApi.Sql(body, true);
            body = "CREATE TABLE IF NOT EXISTS test (body text, title string)";
            var res = utilsApi.Sql(body, true);
            System.Console.WriteLine(res);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IndexApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IndexApi
            Assert.IsType<IndexApi>(instance);
        }

        /// <summary>
        /// Test Bulk
        /// </summary>
        [Fact]
        public void BulkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string body = "{\"insert\": {\"index\": \"test\", \"id\": 1, \"doc\": {\"title\": \"Title 1\"}}}" + "\n";
            var response = instance.Bulk(body);
            Assert.IsType<BulkResponse>(response);
        }
        
        /// <summary>
        /// Test Insert
        /// </summary>
        [Fact]
        public void InsertTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
           Dictionary<string, Object> doc = new Dictionary<string, Object>(); 
           doc.Add("body", "test");
           doc.Add("title", "test");
           InsertDocumentRequest insertDocumentRequest = new InsertDocumentRequest(index: "test", id: 1, doc: doc);
           insertDocumentRequest = new InsertDocumentRequest(index: "test", id: 2, doc: doc);
           var response = instance.Insert(insertDocumentRequest);
           Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test Replace
        /// </summary>
        [Fact]
        public void ReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            Dictionary<string, Object> doc = new Dictionary<string, Object>(); 
            doc.Add("body", "test 2");
            doc.Add("title", "test");
            InsertDocumentRequest insertDocumentRequest = new InsertDocumentRequest(index: "test", id: 1, doc: doc);
            var response = instance.Replace(insertDocumentRequest);
            Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Fact]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            Dictionary<string, Object> doc = new Dictionary<string, Object>();
            doc.Add("title", "test 2");
            UpdateDocumentRequest updateDocumentRequest = new UpdateDocumentRequest(index: "test", id: 2, doc: doc);
            var response = instance.Update(updateDocumentRequest);
            Assert.IsType<UpdateResponse>(response);
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            DeleteDocumentRequest deleteDocumentRequest = new DeleteDocumentRequest(index: "test", id: 2);
            var response = instance.Delete(deleteDocumentRequest);
            Assert.IsType<DeleteResponse>(response);
        }


    }
}
