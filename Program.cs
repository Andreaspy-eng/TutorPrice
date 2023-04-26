internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("-----------------------------------------------------------");

    string header;
    header = String.Format("{0}    {1}          {2}       {3}", "Type", "Byte(s) of memory", "Min", "Max");
    Console.WriteLine(header);

    Console.WriteLine("-----------------------------------------------------------");

    string one;
    one = String.Format("sbyte   {0}                         {1}       {2}",sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
    Console.WriteLine(one);

    string two;
    two = String.Format("byte    {0}                            {1}       {2}",sizeof(byte), byte.MinValue, byte.MaxValue);
    Console.WriteLine(two);

    string three;
    three = String.Format("short   {0}                       {1}     {2}",sizeof(short), short.MinValue, short.MaxValue);
    Console.WriteLine(three);

    string four;
    four = String.Format("ushort  {0}                           {1}     {2}",sizeof(ushort), ushort.MinValue,  ushort.MaxValue);
    Console.WriteLine(four);

    string five;
    five = String.Format("int     {0}                   {1} {2}",sizeof(int), int.MinValue,  int.MaxValue);
    Console.WriteLine(five);

    string six;
    six = String.Format("uint    {0}                   {1}    {2}",sizeof(uint), uint.MinValue,  uint.MaxValue);
    Console.WriteLine(six);

    string seven;
    seven = String.Format("long    {0}                   {1}    {2}",sizeof(long), long.MinValue,  long.MaxValue);
    Console.WriteLine(seven);

    string eight;
    eight = String.Format("ulong   {0}                   {1}    {2}",sizeof(ulong), ulong.MinValue,  ulong.MaxValue);
    Console.WriteLine(eight);  
    
    string nine;
    nine = String.Format("float   {0}                   {1}    {2}",sizeof(float), float.MinValue,  float.MaxValue);
    Console.WriteLine(nine);  

    string ten;
    ten = String.Format("double  {0}                   {1}    {2}",sizeof(double), double.MinValue,  double.MaxValue);
    Console.WriteLine(ten);    

    string eleven;
    eleven = String.Format("decimal {0}                   {1}    {2}",sizeof(decimal), decimal.MinValue,  decimal.MaxValue);
    Console.WriteLine(eleven);   

  }
}