using FakeItEasy;
using NUnit.Framework;
using PhoneExercises;
using System;

namespace Tests
{

    public class CallTests
    {
        [Test]
        public void HangUp_WithoutCurrentCall_DoesntCrash()
        {
            var phone = new Phone("","", A.Fake<Screen>(), A.Fake<Battery>());
            phone.HangUp();
            Assert.Pass();
        }
    }
    public class PhoneNumberTests
    {
        [Test]
        public void Test_ValidPhoneNumber_IsOk()
        {
            var phoneNumber = new PhoneNumber("0729678509");
            Assert.AreEqual("0729678509", phoneNumber.Value);
        }

        [Test]
        public void Test_PhoneNumberOnInternationalFormat_IsOk()
        {
            var phoneNumber = new PhoneNumber("+46729678509");
            Assert.AreEqual("+46729678509", phoneNumber.Value);
        }

        [Test]
        public void Test_PhoneNumberIsTooShort_IsNotOk()
        {
            Assert.Throws<ArgumentException>(() => new PhoneNumber("01"));
        }

        [Test]
        public void Test_PhoneNumberWithValidCountryCode_IsOk()
        {
            var phoneNumber = new PhoneNumber("+46729678509");
            Assert.AreEqual("+46729678509", phoneNumber.Value);
        }

        [Test]
        public void Test_PhoneNumberWithNotAllowedCountryCode_IsNotOk()
        {
            Assert.Throws<ArgumentException>(() => new PhoneNumber("+45729678509"));
        }

        [Test]
        public void Test_PhoneNumberThatStartsWithMinus_IsNotOk()
        {
            Assert.Throws<ArgumentException>(() => new PhoneNumber("-0729678509"));
        }

        [Test]
        public void Test_PhoneNumberThatWithOtherCharacters_IsNotOk()
        {
            Assert.Throws<ArgumentException>(() => new PhoneNumber("hejsan svejsan"));
        }

        [Test]
        public void Test_PhoneNumberWithPrettyFormat_IsOk()
        {
            var phoneNumber = new PhoneNumber("+46 72 967 85 09");
            Assert.AreEqual("+46729678509", phoneNumber.Value);
        }

        [Test]
        public void Test_PhoneNumberWithPrettyFormat2_IsOk()
        {
            var phoneNumber = new PhoneNumber("072-967 85 09");
            Assert.AreEqual("0729678509", phoneNumber.Value);
        }

    }
}