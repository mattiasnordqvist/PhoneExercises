using NUnit.Framework;
using PhoneExercises;

namespace Tests
{
    public class ScreenTests
    {
        [Test]
        public void CreateScreen_WithoutColorType_DefaultsToColor()
        {
            var screen = new Screen(10);
            Assert.AreEqual(ScreenColor.Color, screen.ColorConfiguration);
        }

        [Test]
        public void CreateScreen_WithoutBlackAndWhiteColorConfiguration_HasBlackWhiteColors()
        {
            var screen = new Screen(10, ScreenColor.BlackWhite);
            Assert.AreEqual(ScreenColor.BlackWhite, screen.ColorConfiguration);
        }

    }
}