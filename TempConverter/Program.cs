Console.WriteLine("Enter a value in Celsius: ");
float c = float.Parse(Console.ReadLine());

float f = c * 9 / 5 + 32;
double k = c + 273.15;

Console.WriteLine($"{c}°C equals to {f}°F");
Console.WriteLine($"{c}°C equals to {k}K");