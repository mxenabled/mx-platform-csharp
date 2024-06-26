/*
 * MX Platform API
 *
 * The MX Platform API is a powerful, fully-featured API designed to make aggregating and enhancing financial data easy and reliable. It can seamlessly connect your app or website to tens of thousands of financial institutions.
 *
 * The version of the OpenAPI document: 0.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Api;
// uncomment below to import models
//using MX.Platform.CSharp.Model;

namespace MX.Platform.CSharp.Test.Api
{
    /// <summary>
    ///  Class for testing InsightsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InsightsApiTests : IDisposable
    {
        private InsightsApi instance;

        public InsightsApiTests()
        {
            instance = new InsightsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InsightsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InsightsApi
            //Assert.IsType<InsightsApi>(instance);
        }

        /// <summary>
        /// Test ListAccountsInsight
        /// </summary>
        [Fact]
        public void ListAccountsInsightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //string insightGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListAccountsInsight(userGuid, insightGuid, page, recordsPerPage);
            //Assert.IsType<AccountsResponseBody>(response);
        }

        /// <summary>
        /// Test ListCategoriesInsight
        /// </summary>
        [Fact]
        public void ListCategoriesInsightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //string insightGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListCategoriesInsight(userGuid, insightGuid, page, recordsPerPage);
            //Assert.IsType<CategoriesResponseBody>(response);
        }

        /// <summary>
        /// Test ListInsightsByAccount
        /// </summary>
        [Fact]
        public void ListInsightsByAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountGuid = null;
            //string userGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListInsightsByAccount(accountGuid, userGuid, page, recordsPerPage);
            //Assert.IsType<InsightsResponseBody>(response);
        }

        /// <summary>
        /// Test ListInsightsUser
        /// </summary>
        [Fact]
        public void ListInsightsUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListInsightsUser(userGuid, page, recordsPerPage);
            //Assert.IsType<InsightsResponseBody>(response);
        }

        /// <summary>
        /// Test ListMerchantsInsight
        /// </summary>
        [Fact]
        public void ListMerchantsInsightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //string insightGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListMerchantsInsight(userGuid, insightGuid, page, recordsPerPage);
            //Assert.IsType<MerchantsResponseBody>(response);
        }

        /// <summary>
        /// Test ListScheduledPaymentsInsight
        /// </summary>
        [Fact]
        public void ListScheduledPaymentsInsightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //string insightGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListScheduledPaymentsInsight(userGuid, insightGuid, page, recordsPerPage);
            //Assert.IsType<ScheduledPaymentsResponseBody>(response);
        }

        /// <summary>
        /// Test ListTransactionsInsight
        /// </summary>
        [Fact]
        public void ListTransactionsInsightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //string insightGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListTransactionsInsight(userGuid, insightGuid, page, recordsPerPage);
            //Assert.IsType<TransactionsResponseBody>(response);
        }

        /// <summary>
        /// Test ReadInsightsUser
        /// </summary>
        [Fact]
        public void ReadInsightsUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //string insightGuid = null;
            //var response = instance.ReadInsightsUser(userGuid, insightGuid);
            //Assert.IsType<InsightResponseBody>(response);
        }

        /// <summary>
        /// Test UpdateInsight
        /// </summary>
        [Fact]
        public void UpdateInsightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //string insightGuid = null;
            //InsightUpdateRequest insightUpdateRequest = null;
            //var response = instance.UpdateInsight(userGuid, insightGuid, insightUpdateRequest);
            //Assert.IsType<InsightResponse>(response);
        }
    }
}
