// <copyright file="ProgramTest.cs">Copyright ©  2018</copyright>
using System;
using Binary_Search;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binary_Search.Tests
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProgramTest
    {
    }
}
