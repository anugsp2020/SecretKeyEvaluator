using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SecretKeyEvaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SecretKeyEvaluator.Tests
{
    [TestFixture]
    public class StringHelperTests
    {
        Assembly assembly;
        Type className;
        [SetUp]
        public void SetUp()
        {
            assembly = Assembly.Load("SecretKeyEvaluator");
            className = assembly.GetType("SecretKeyEvaluator.StringHelper");
        }
        [Test]
        public void IsValidSecretKey1_MethodInclusion_ReturnsNotNull()
        {
            var allBindings = BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

            if (className != null)
            {
                var method = className.GetMethod("IsValidSecretKey1", allBindings);

                NUnit.Framework.Assert.That(method != null, "Method IsValidSecretKey1 is not implemented or check spelling");
            }
            else
            {
                NUnit.Framework.Assert.Fail("No class with the name 'StringHelper' is implemented Or the class name is wrong");
            }

          
        }
        [Test]
        public void IsValidSecretKey1_ValidString_ReturnsTrue()
        {
            var result = StringHelper.IsValidSecretKey1("abc");

            NUnit.Framework.Assert.That(result, Is.EqualTo(true));
        }
        [Test]
        public void IsValidSecretKey1_ValidString_ReturnsFalse()
        {
            var result = StringHelper.IsValidSecretKey1("abcc");

            NUnit.Framework.Assert.That(result, Is.EqualTo(false));
        }


        [Test]
        public void IsValidSecretKey2_ValidString_ReturnsTrue()
        {
            var result = StringHelper.IsValidSecretKey2("abc123");

            NUnit.Framework.Assert.That(result, Is.EqualTo(true));
        }
        [Test]
        public void IsValidSecretKey2_ValidString_ReturnsFalse()
        {
            var result = StringHelper.IsValidSecretKey2("abc120");

            NUnit.Framework.Assert.That(result, Is.EqualTo(false));
        }
        [Test]
        public void IsValidSecretKey2_MethodInclusion_ReturnsNotNull()
        {
            var allBindings = BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

            if (className != null)
            {
                var method = className.GetMethod("IsValidSecretKey2", allBindings);

                NUnit.Framework.Assert.That(method != null, "Method IsValidSecretKey2 is not implemented or check spelling");
            }
            else
            {
                NUnit.Framework.Assert.Fail("No class with the name 'StringHelper' is implemented Or the class name is wrong");
            }


        }
    }
}