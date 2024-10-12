using System;
//Реализуйте операторы неявного приведения из long,int, byt в Bits.

public class Bits
{
    private ulong bitValue;

    public Bits(ulong value)
    {
        bitValue = value;
    }
    public static implicit operator Bits(long value)
    {
        return new Bits((ulong)value);
    }
    public static implicit operator Bits(int value)
    {
        return new Bits((ulong)value);
    }
    public static implicit operator Bits(byte value)
    {
        return new Bits((ulong)value);
    }
    public override string ToString()
    {
        return $"Bits: {bitValue}";
    }
}
class Program
{
    static void Main()
    {
        Bits fromLong = 1234567890123456789L; 
        Bits fromInt = 12345;                 
        Bits fromByte = (byte)255;

        Console.WriteLine(fromLong);        
        Console.WriteLine(fromInt);
        Console.WriteLine(fromByte);
    }
}
