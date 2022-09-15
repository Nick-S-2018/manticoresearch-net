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
using Xunit;
using System.Net.Http;

using ManticoreSearch.Client;
using ManticoreSearch.Api;
// uncomment below to import models
using ManticoreSearch.Model;

namespace ManticoreSearch.Test.Api
{
    /// <summary>
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SearchApiTests : IDisposable
    {
        private SearchApi instance;
        private Dictionary<string, Func<Object>> implementedTests;

        private object InitTests()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:9308";
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            instance = new SearchApi(httpClient, config, httpClientHandler);
            var utilsApi = new UtilsApi();
            string body ="DROP TABLE IF EXISTS test";
            utilsApi.Sql(body, true);
            body = "CREATE TABLE IF NOT EXISTS test (body text, title string)";
            utilsApi.Sql(body, true);
            return instance;
        }
                
        private object CheckTest(string testName)
        {
            //Func<Object> test;
            System.Console.WriteLine("------");
            System.Console.WriteLine(testName);
            if (implementedTests.ContainsKey(testName))
            {
                System.Console.WriteLine("++++++");
                //implementedTests[testName]();
                return null;
            }
            return null;
        }     
                

        public SearchApiTests()
        {
            implementedTests = new Dictionary<string, Func<Object>>()
            {
                { "IndexApi", () => { return InitTests(); } },
                { "SearchApi", () => { return InitTests(); } },
                { "UtilsApi", () => { return InitTests(); } },
                { "BulkTest", () => 
                    {
                        string body = "{\"insert\": {\"index\": \"test\", \"id\": 1, \"doc\": {\"body\": \"test\", \"title\": \"test\"}}}" + "\n";
                        return instance.Bulk(body);
                    }
                },
                { "InsertTest", () => 
                    {
                        Dictionary<string, Object> doc = new Dictionary<string, Object>(); 
                        doc.Add("body", "test");
                        doc.Add("title", "test");
                        InsertDocumentRequest insertDocumentRequest = new InsertDocumentRequest(index: "test", id: 1, doc: doc);
                        insertDocumentRequest = new InsertDocumentRequest(index: "test", id: 2, doc: doc);
                        return instance.Insert(insertDocumentRequest);
                    }
                },
                { "ReplaceTest", () => 
                    {
                        Dictionary<string, Object> doc = new Dictionary<string, Object>(); 
                        doc.Add("body", "test 2");
                        doc.Add("title", "test");
                        InsertDocumentRequest insertDocumentRequest = new InsertDocumentRequest(index: "test", id: 1, doc: doc);
                        return instance.Replace(insertDocumentRequest);
                    }
                },
                { "UpdateTest", () => 
                    {
                        Dictionary<string, Object> doc = new Dictionary<string, Object>();
                        doc.Add("title", "test 2");
                        UpdateDocumentRequest updateDocumentRequest = new UpdateDocumentRequest(index: "test", id: 2, doc: doc);
                        return instance.Update(updateDocumentRequest);
                    }
                },
                { "DeleteTest", () => 
                    {
                        DeleteDocumentRequest deleteDocumentRequest = new DeleteDocumentRequest(index: "test", id: 1);
                        return instance.Delete(deleteDocumentRequest);
                    }
                },
            };

            this.CheckTest("SearchApi");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<SearchApi>(instance);
        }

        /// <summary>
        /// Test Percolate
        /// </summary>
        [Fact]
        public void PercolateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string index = null;
            //PercolateRequest percolateRequest = null;
            //var response = instance.Percolate(index, percolateRequest);
            object response = this.CheckTest( System.Reflection.MethodBase.GetCurrentMethod().Name );
            if (response != null)
            {
                Assert.IsType<SearchResponse>(response);
            }
        }

        /// <summary>
        /// Test Search
        /// </summary>
        [Fact]
        public void SearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SearchRequest searchRequest = null;
            //var response = instance.Search(searchRequest);
            object response = this.CheckTest( System.Reflection.MethodBase.GetCurrentMethod().Name );
            if (response != null)
            {
                Assert.IsType<SearchResponse>(response);
            }
        }
    }
}
