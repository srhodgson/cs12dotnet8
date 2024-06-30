string rowSeparator = new string('-', count: 104);
Console.WriteLine(rowSeparator);
Console.WriteLine($"Type   {"Byte(s) of memory",-4} {"Min",32} {"Max",45}");
Console.WriteLine(rowSeparator);
Console.WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,45} {sbyte.MaxValue,45}");
Console.WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,45} {byte.MaxValue,45}");
Console.WriteLine($"short   {sizeof(short),-4} {short.MinValue,45} {short.MaxValue,45}");
Console.WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,45} {ushort.MaxValue,45}");
Console.WriteLine($"int     {sizeof(int),-4} {int.MinValue,45} {int.MaxValue,45}");
Console.WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,45} {uint.MaxValue,45}");
Console.WriteLine($"long    {sizeof(long),-4} {long.MinValue,45} {long.MaxValue,45}");
Console.WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,45} {ulong.MaxValue,45}");
unsafe
{
    Console.WriteLine($"Int128  {sizeof(Int128),-4} {Int128.MinValue,45} {Int128.MaxValue,45}");
    Console.WriteLine($"UInt128 {sizeof(UInt128),-4} {UInt128.MinValue,45} {UInt128.MaxValue,45}");
    Console.WriteLine($"Half    {sizeof(Half),-4} {Half.MinValue,45} {Half.MaxValue,45}");
}
Console.WriteLine($"float   {sizeof(float),-4} {float.MinValue,45} {float.MaxValue,45}");
Console.WriteLine($"double  {sizeof(double),-4} {double.MinValue,45} {double.MaxValue,45}");
Console.WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,45} {decimal.MaxValue,45}");
Console.WriteLine(rowSeparator);