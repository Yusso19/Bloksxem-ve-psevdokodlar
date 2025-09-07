//3 axrinci misal
int x = 5;
int y = -3;
if (x > 0 && y < 0)
{
    Console.WriteLine("X musbet , Y menfi");
}
if (x > 0 && y > 0)
{
    Console.WriteLine("her 2 si musbet");
}

//2  ci misal
Console.WriteLine("kakaya temperatura");
string input = Console.ReadLine();
int a = Convert.ToInt32(input);

if (a < 0)
{
    Console.WriteLine("Donma");
}
if (a >= 0 && a <= 15)
{
    Console.WriteLine("Soyug");
}
if (a >= 16 && a <= 30)
{
    Console.WriteLine("Mulaim");
}
if (a > 30)
{
    Console.WriteLine("Isti");
}

//Console.WriteLine();
//string input = Console.ReadLine();
//int a = Convert.ToInt32(input);

//Console.WriteLine();
//string input = Console.ReadLine();
//int b = Convert.ToInt32(input);

//Console.WriteLine();
//string input = Console.ReadLine();
//int c = Convert.ToInt32(input);
 
//3 cu misal
Console.Write("a-ni daxil edin: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b-ni daxil edin: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c-ni daxil edin: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"a = {a}, b = {b}, c = {c}");

if (a > b && a > c)
{
    Console.WriteLine($"En boyuk eded a-dir: {a}");
}
if (b > a && b > c)
{
    Console.WriteLine($"En boyuk eded b-dir: {b}");
}
if (c > a && c > b)
{
    Console.WriteLine($"En boyuk eded c-dir: {c}");
}