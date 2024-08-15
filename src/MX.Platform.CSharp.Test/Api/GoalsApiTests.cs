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
    ///  Class for testing GoalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GoalsApiTests : IDisposable
    {
        private GoalsApi instance;

        public GoalsApiTests()
        {
            instance = new GoalsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GoalsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GoalsApi
            //Assert.IsType<GoalsApi>(instance);
        }

        /// <summary>
        /// Test UsersUserGuidGoalsGet
        /// </summary>
        [Fact]
        public void UsersUserGuidGoalsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //string? page = null;
            //string? recordsPerAge = null;
            //var response = instance.UsersUserGuidGoalsGet(userGuid, page, recordsPerAge);
            //Assert.IsType<GoalsResponseBody>(response);
        }

        /// <summary>
        /// Test UsersUserGuidGoalsGoalGuidDelete
        /// </summary>
        [Fact]
        public void UsersUserGuidGoalsGoalGuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string goalGuid = null;
            //string userGuid = null;
            //instance.UsersUserGuidGoalsGoalGuidDelete(goalGuid, userGuid);
        }

        /// <summary>
        /// Test UsersUserGuidGoalsGoalGuidGet
        /// </summary>
        [Fact]
        public void UsersUserGuidGoalsGoalGuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string goalGuid = null;
            //string userGuid = null;
            //var response = instance.UsersUserGuidGoalsGoalGuidGet(goalGuid, userGuid);
            //Assert.IsType<GoalResponseBody>(response);
        }

        /// <summary>
        /// Test UsersUserGuidGoalsGoalGuidPut
        /// </summary>
        [Fact]
        public void UsersUserGuidGoalsGoalGuidPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string goalGuid = null;
            //string userGuid = null;
            //UpdateGoalRequestBody updateGoalRequestBody = null;
            //var response = instance.UsersUserGuidGoalsGoalGuidPut(goalGuid, userGuid, updateGoalRequestBody);
            //Assert.IsType<GoalResponseBody>(response);
        }

        /// <summary>
        /// Test UsersUserGuidGoalsPost
        /// </summary>
        [Fact]
        public void UsersUserGuidGoalsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //GoalRequestBody goalRequestBody = null;
            //var response = instance.UsersUserGuidGoalsPost(userGuid, goalRequestBody);
            //Assert.IsType<GoalResponseBody>(response);
        }

        /// <summary>
        /// Test UsersUserGuidGoalsRepositionPut
        /// </summary>
        [Fact]
        public void UsersUserGuidGoalsRepositionPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //RepositionRequestBody repositionRequestBody = null;
            //var response = instance.UsersUserGuidGoalsRepositionPut(userGuid, repositionRequestBody);
            //Assert.IsType<RepositionResponseBody>(response);
        }
    }
}