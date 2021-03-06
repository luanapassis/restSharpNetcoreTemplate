﻿using NUnit.Framework;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Bases
{
    public class TestBase
    {
        public DataBaseSteps dataBaseSteps = new DataBaseSteps();

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dataBaseSteps.cargaTabelaUsuario();
            dataBaseSteps.cargaProjeto();
            ExtentReportHelpers.CreateReport();
        }

        [SetUp]
        public void SetUp()
        {
            ExtentReportHelpers.AddTest();
        }

        [TearDown]
        public void TearDown()
        {
            ExtentReportHelpers.AddTestResult();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ExtentReportHelpers.GenerateReport();
        }
    }
}
