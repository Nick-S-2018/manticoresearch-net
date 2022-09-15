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
    ///  Class for testing IndexApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IndexApiTests : IDisposable
    {
        private IndexApi instance;
        private Dictionary<string, Func<Object,Object>> implementedTests;

        private object InitTests()
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
            utilsApi.Sql(body, true);
            return instance;
        }
                
        private object CheckTest(string testName)
        {
            // Func<Object,Object> test;
            // if (implementedTests.TryGetValue(testName, out test))
            // {
            //     return test(instance);
            // }
            return null;
        }     



        public IndexApiTests()
        {
            implementedTests = new Dictionary<string, Dictionary<string,Func>>
            {
                { "IndexApi", 
                    {
                        { "InsertTest", (IndexApi p) => 
                            {
                                Dictionary<string, Object> doc = new Dictionary<string, Object>(); 
                                doc.Add("body", "test");
                                doc.Add("title", "test");
                                InsertDocumentRequest insertDocumentRequest = new InsertDocumentRequest(index: "test", id: 1, doc: doc);
                                insertDocumentRequest = new InsertDocumentRequest(index: "test", id: 2, doc: doc);
                                return p.Insert(insertDocumentRequest);
                            }
                        },
                        { "ReplaceTest", (IndexApi p) => 
                            {
                                Dictionary<string, Object> doc = new Dictionary<string, Object>(); 
                                doc.Add("body", "test 2");
                                doc.Add("title", "test");
                                InsertDocumentRequest insertDocumentRequest = new InsertDocumentRequest(index: "test", id: 1, doc: doc);
                                return p.Replace(insertDocumentRequest);
                            }
                        },
                        { "UpdateTest", (IndexApi p) => 
                            {
                                Dictionary<string, Object> doc = new Dictionary<string, Object>();
                                doc.Add("title", "test 2");
                                UpdateDocumentRequest updateDocumentRequest = new UpdateDocumentRequest(index: "test", id: 2, doc: doc);
                                return p.Update(updateDocumentRequest);
                            }
                        },
                        { "DeleteTest", (IndexApi p) => 
                            {
                                DeleteDocumentRequest deleteDocumentRequest = new DeleteDocumentRequest(index: "test", id: 1);
                                return p.Delete(deleteDocumentRequest);
                            }
                        }
                    }
                }
            };

            IntiTests();
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
            Assert.IsType<IndexApi>(instance);
        }

        /// <summary>
        /// Test Bulk
        /// </summary>
        [Fact]
        public void BulkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //var response = instance.Bulk(body);
            object response = this.CheckTest( System.Reflection.MethodBase.GetCurrentMethod().Name );
            if (response != null)
            {
                Assert.IsType<BulkResponse>(response);
            }
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteDocumentRequest deleteDocumentRequest = null;
            //var response = instance.Delete(deleteDocumentRequest);
            object response = this.CheckTest( System.Reflection.MethodBase.GetCurrentMethod().Name );
            if (response != null)
            {
                Assert.IsType<DeleteResponse>(response);
            }
        }

        /// <summary>
        /// Test Insert
        /// </summary>
        [Fact]
        public void InsertTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InsertDocumentRequest insertDocumentRequest = null;
            //var response = instance.Insert(insertDocumentRequest);
            object response = this.CheckTest( System.Reflection.MethodBase.GetCurrentMethod().Name );
            if (response != null)
            {
                Assert.IsType<SuccessResponse>(response);
            }
        }

        /// <summary>
        /// Test Replace
        /// </summary>
        [Fact]
        public void ReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InsertDocumentRequest insertDocumentRequest = null;
            //var response = instance.Replace(insertDocumentRequest);
            object response = this.CheckTest( System.Reflection.MethodBase.GetCurrentMethod().Name );
            if (response != null)
            {
                Assert.IsType<SuccessResponse>(response);
            }
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Fact]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateDocumentRequest updateDocumentRequest = null;
            //var response = instance.Update(updateDocumentRequest);
            object response = this.CheckTest( System.Reflection.MethodBase.GetCurrentMethod().Name );
            if (response != null)
            {
                Assert.IsType<UpdateResponse>(response);
            }
        }
    }
}
