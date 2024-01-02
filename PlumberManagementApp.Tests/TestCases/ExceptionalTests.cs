﻿

using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlumberManagementApp.DAL.Interfaces;
using PlumberManagementApp.DAL.Services;
using Xunit;
using Xunit.Abstractions;

namespace PlumberManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IPlumberService _plumberService;
        public readonly Mock<IPlumberRepository> plumberservice = new Mock<IPlumberRepository>();

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
        {
            _plumberService = new PlumberService(plumberservice.Object);
            _output = output;
        }

        [Fact]
        public async Task<bool> Testfor_GetAll_Plumbers_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                plumberservice.Setup(repos => repos.GetAll()).Returns("");
                var result = _plumberService.GetAll();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Update_Plumbers_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                plumberservice.Setup(repos => repos.Update()).Returns("");
                var result = _plumberService.Update();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


    }
}