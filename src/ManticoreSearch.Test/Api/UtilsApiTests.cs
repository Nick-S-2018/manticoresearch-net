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
    ///  Class for testing UtilsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UtilsApiTests : IDisposable
    {
        private UtilsApi instance;
        private Dictionary<string, Func<Object,Object>> implementedTests;

        private object InitTests()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:9308";
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            instance = new UtilsApi(httpClient, config, httpClientHandler);
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
                

        public UtilsApiTests()
        {
            

            this.CheckTest("UtilsApi");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UtilsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<UtilsApi>(instance);
        }

        /// <summary>
        /// Test Sql
        /// </summary>
        [Fact]
        public void SqlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //bool? rawResponse = null;
            //var response = instance.Sql(body, rawResponse);
            object response = this.CheckTest( System.Reflection.MethodBase.GetCurrentMethod().Name );
            if (response != null)
            {
                Assert.IsType<List<Object>>(response);
            }
        }
    }
}
