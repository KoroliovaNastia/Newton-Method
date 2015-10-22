using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newton_Method;
using NUnit.Framework;

namespace UnitTestNewton_Method
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(3, 2, 0.001)]
        [TestCase(3, 2, -0.1, ExpectedException = typeof (ArgumentOutOfRangeException))]
        [TestCase(3, -2, 0.001)]
        [TestCase(2, -2, 0.001, ExpectedException = typeof(ArgumentException))]

        public void Newton_Method(int n, double x, double eps)
        {

            double result = Logic.Algorithm(n, x, eps);
            double result1 = System.Math.Pow(-2, 1.0 / 3);
            Assert.AreEqual(result, result1, eps);

        }

        //public void TestOnValidParams()
        //{
        //    //arrange
        //}
    }
}
