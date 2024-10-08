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
    ///  Class for testing MicrodepositsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MicrodepositsApiTests : IDisposable
    {
        private MicrodepositsApi instance;

        public MicrodepositsApiTests()
        {
            instance = new MicrodepositsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MicrodepositsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MicrodepositsApi
            //Assert.IsType<MicrodepositsApi>(instance);
        }

        /// <summary>
        /// Test MicroDepositsMicrodepositGuidVerifyPut
        /// </summary>
        [Fact]
        public void MicroDepositsMicrodepositGuidVerifyPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string microdepositGuid = null;
            //MicrodepositVerifyRequestBody? microdepositVerifyRequestBody = null;
            //var response = instance.MicroDepositsMicrodepositGuidVerifyPut(microdepositGuid, microdepositVerifyRequestBody);
            //Assert.IsType<MicrodepositResponseBody>(response);
        }

        /// <summary>
        /// Test UsersUserGuidMicroDepositsGet
        /// </summary>
        [Fact]
        public void UsersUserGuidMicroDepositsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //var response = instance.UsersUserGuidMicroDepositsGet(userGuid);
            //Assert.IsType<MicrodepositsResponseBody>(response);
        }

        /// <summary>
        /// Test UsersUserGuidMicroDepositsMicroDepositGuidDelete
        /// </summary>
        [Fact]
        public void UsersUserGuidMicroDepositsMicroDepositGuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string microDepositGuid = null;
            //string userGuid = null;
            //instance.UsersUserGuidMicroDepositsMicroDepositGuidDelete(microDepositGuid, userGuid);
        }

        /// <summary>
        /// Test UsersUserGuidMicroDepositsMicroDepositGuidGet
        /// </summary>
        [Fact]
        public void UsersUserGuidMicroDepositsMicroDepositGuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //string microDepositGuid = null;
            //var response = instance.UsersUserGuidMicroDepositsMicroDepositGuidGet(userGuid, microDepositGuid);
            //Assert.IsType<MicrodepositResponseBody>(response);
        }

        /// <summary>
        /// Test UsersUserGuidMicroDepositsPost
        /// </summary>
        [Fact]
        public void UsersUserGuidMicroDepositsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //MicrodepositRequestBody microdepositRequestBody = null;
            //var response = instance.UsersUserGuidMicroDepositsPost(userGuid, microdepositRequestBody);
            //Assert.IsType<MicrodepositResponseBody>(response);
        }
    }
}
