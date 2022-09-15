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
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SearchApiTests : IDisposable
    {
        private SearchApi instance;

        private void InitTests()
        {
            System.Console.WriteLine("ok");
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
        }
                
        private Dictionary<string, Action> implementedTests;
        
        private void CheckTest(string testName)
        {
            System.Console.WriteLine("-----");
            System.Console.WriteLine(testName);
            Action act;
            if (implementedTests.TryGetValue(testName, out act))
            {
                System.Console.WriteLine(instance);
                act();
                System.Console.WriteLine(instance);
            }
        }  

        public SearchApiTests()
        {
            implementedTests = new Dictionary<string, Action>()
            {
                { "IndexApiTests", () => { InitTests(); } },
                { "SearchApiTests", () => { InitTests(); } },
                { "UtilsTests", () => { InitTests(); } },
            };

            this.CheckTest( System.Reflection.MethodBase.GetCurrentMethod().Name );
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
            //Assert.IsType<SearchResponse>(response);
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
            //Assert.IsType<SearchResponse>(response);
        }
    }
}
