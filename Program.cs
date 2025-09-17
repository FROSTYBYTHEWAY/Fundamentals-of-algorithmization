using System;

class Program
{
    static void Main(string[] args)
    {
        byte byteVar = 255;
        sbyte sbyteVar = -128;
        short shortVar = 4324;
        ushort ushortVar = 32443;
        int intVar = 12354;
        uint uintVar = 34134144;
        long longVar = 123442424242;
        ulong ulongVar = 131314525252525;
        float floatVar = 3.14f;
        double doubleVar = 3.32424524;
        decimal decimalVar = 123.42442m;

        char charVar = 'A';
        bool boolVar = true;
        string stringVar = "Hello";
        object objectVar = new object();

        Console.WriteLine($"значение переменной byteVar - {byteVar}");
        Console.WriteLine($"значение переменной sbyteVar - {sbyteVar}");
        Console.WriteLine($"значение переменной shortVar - {shortVar}");
        Console.WriteLine($"значение переменной ushortVar - {ushortVar}");
        Console.WriteLine($"значение переменной intVar - {intVar}");
        Console.WriteLine($"значение переменной uintVar - {uintVar}");
        Console.WriteLine($"значение переменной longVar - {longVar}");
        Console.WriteLine($"значение переменной ulongVar - {ulongVar}");
        Console.WriteLine($"значение переменной floatVar - {floatVar}");
        Console.WriteLine($"значение переменной doubleVar - {doubleVar}");
        Console.WriteLine($"значение переменной decimalVar - {decimalVar}");
        Console.WriteLine($"значение переменной charVar - {charVar}");
        Console.WriteLine($"значение переменной boolVar - {boolVar}");
        Console.WriteLine($"значение переменной stringVar - {stringVar}");
        Console.WriteLine($"значение переменной objectVar - {objectVar}");

        Console.ReadKey();

    }
}