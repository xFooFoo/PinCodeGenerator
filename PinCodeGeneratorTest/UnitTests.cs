using PinCodeGeneratorTest;


namespace PinCodeGeneratorTest
{
    public class UnitTests
    {
        [Fact]
        public void GenerateValidPins_ShouldHaveAtLeast1000Pins()
        {
            Assert.True(PinCodeGenerator.GenerateValidPins().Count >= 1000, "There should be at least 1000 valid PIN codes generated.");
        }

        [Fact]
        public void GenerateValidPins_ShouldHaveUniquePins()
        {
            List<string> validPins = PinCodeGenerator.GenerateValidPins();
            Assert.Equal(validPins.Distinct().Count(), validPins.Count);

        }

        public void OutputRandomValidPins_ShouldOutputPinsEqualToInput()
        {
            List<string> pins = new List<string> { "1234", "5678", "9012" };
            PinCodeGenerator.OutputRandomValidPins(pins, pins.Count);
        }
    }
}
