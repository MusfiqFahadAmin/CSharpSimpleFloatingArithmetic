using System;

namespace FloatingArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // decimal is Generally Used to Represent Money
            decimal airplanePrice = 300000.00m;

            // double is Generally Used to Represent Physical Properties
            double speedOfLight = 2.99792458e8;

            // int and double can Work Together without Conversion
            double airplaneLength = 130.98;
            double airplaneWidth = 30.57;
            double airplaneTriangleArea = (airplaneLength * airplaneWidth) / 2; // 2 is an int

            // decimal and double need Conversion to Work Together
            decimal airplanePricePerFeet = airplanePrice / (decimal)airplaneLength;

            double doubleNumber = 10.0;
            double oneTenthOfDoubleNumber = 0.1;

            // Addition of Multiple Doubles May Result Different as double is Very Precise
            double addedOneTenthOfDoubleNumber = oneTenthOfDoubleNumber + oneTenthOfDoubleNumber
                                               + oneTenthOfDoubleNumber + oneTenthOfDoubleNumber
                                               + oneTenthOfDoubleNumber + oneTenthOfDoubleNumber
                                               + oneTenthOfDoubleNumber + oneTenthOfDoubleNumber
                                               + oneTenthOfDoubleNumber + oneTenthOfDoubleNumber;

            Console.WriteLine($"Speed of Light: {speedOfLight} m/s\n" +
                              $"Airplane Triangle Area: {airplaneTriangleArea} feet\n" +
                              $"Airplane Price Per Feet: ${airplanePricePerFeet}\n" +
                              $"{doubleNumber} is Equal to {addedOneTenthOfDoubleNumber}: " +
                              $"{doubleNumber == addedOneTenthOfDoubleNumber}\n");
        }
    }
}
