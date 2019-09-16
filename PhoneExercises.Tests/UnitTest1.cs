using FakeItEasy;
using NUnit.Framework;
using PhoneExercises;
using System;

namespace Tests
{
    public class PhoneTests
    {
        [Test]
        public void CreatePhone_WithoutManufacturer_ThrowsException()
        {

            Assert.Throws<ArgumentException>(() => new Phone("7.1", null, A.Fake<Screen>(), A.Fake<Battery>()));
        }

        [Test]
        public void CreatePhone_WithoutBattery_ThrowsException()
        {
            var screen = new Screen(9, ScreenColor.BlackWhite);
            Assert.Throws<ArgumentException>(() => new Phone("7.1", "Nokia", screen, null));
        }

        [Test]
        public void CreatePhone_WithoutScreen_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Phone("7.1", "Nokia", null, A.Fake<Battery>()));
        }
    }
}