﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questionnaire.Web;
using Questionnaire.Web.Controllers;

namespace Questionnaire.Web.Tests.Controllers
{
    [TestClass]
    public class FormsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            FormsController controller = new FormsController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void GetById()
        {
        }

        [TestMethod]
        public void Post()
        {
        }

        [TestMethod]
        public void Put()
        {
        }

        [TestMethod]
        public void Delete()
        {
        }
    }
}
