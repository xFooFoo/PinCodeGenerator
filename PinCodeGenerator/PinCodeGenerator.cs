using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PinCodeGenerator
{
    /*
    This program needs to generate 1000 valid and unique 4-digit PIN codes. 
    A valid PIN code must meet the following criteria:
    1. It must be exactly 4 digits long.
    2. It must not contain any CONSECUTIVE repeated digits.
    For example, "1234" is valid, but "1123" and "1233" are not valid because they contain consecutive repeated digits.
    3. It must be a valid integer
    4. It must not contain any CONSECUTIVE incremental digits (by 1).
    For example, "1234" is not valid because it contains consecutive incremental digits, but "1357" is valid.
*/

    // Generate valid PIN codes
    public static List<string> GenerateValidPins()
    {
        int MIN_PIN = 1000;
        int MAX_PIN = 9999;
        List<int> incrementalOrRepeatingDifference = new List<int>() { 0, 1 }; // 0 for repeating digits, 1 for incremental digits
        List<string> validPins = new List<string>();

        for (int pin = MIN_PIN; pin <= MAX_PIN; pin++)
        {
            string pinStr = pin.ToString();

            if (!incrementalOrRepeatingDifference.Contains(pinStr[3] - pinStr[2]) &&
                !incrementalOrRepeatingDifference.Contains(pinStr[2] - pinStr[1]) &&
                !incrementalOrRepeatingDifference.Contains(pinStr[1] - pinStr[0]))
            {
                validPins.Add(pinStr);
            }
        }
        return validPins;
    }

    // Output a specified number of random valid PIN codes
    public static void OutputRandomValidPins(List<string> validPins, int count)
    {
        for (int i = 0; i < count && i < validPins.Count; i++)
        {
            int randomIndex = new Random().Next(validPins.Count);
            Console.WriteLine(validPins[randomIndex]);
            validPins.RemoveAt(randomIndex); // Makes sure uniqueness
        }
    }
}