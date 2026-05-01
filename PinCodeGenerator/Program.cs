class Program

{
    public static void Main()
    {
        List<string> validPins = PinCodeGenerator.GenerateValidPins();
        PinCodeGenerator.OutputRandomValidPins(validPins, 1000);
    }
}