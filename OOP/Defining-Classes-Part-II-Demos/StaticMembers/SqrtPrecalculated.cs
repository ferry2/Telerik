using System;

class SqrtPrecalculated
{
    public const int MAX_VALUE = 10000;
        
    // Static field
    private static double[] sqrtValues; 

    // Static constructor 
    static SqrtPrecalculated()
    {
        sqrtValues = new double[MAX_VALUE + 1];
        for (int i = 0; i < sqrtValues.Length; i++)
        {
            sqrtValues[i] = Math.Sqrt(i);
        }
    }

    // Static method 
    public static double GetSqrt(int value)
    {
        return sqrtValues[value];
    }

    // The Main() method is always static
    static void Main()
    {
		Console.WriteLine(SqrtPrecalculated.GetSqrt(78));
    } 
}
