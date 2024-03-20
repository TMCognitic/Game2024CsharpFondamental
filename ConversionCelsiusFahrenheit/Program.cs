namespace ConversionCelsiusFahrenheit;

internal class Program
{
    static void Main(string[] args)
    {
        Celsius celsius = new Celsius() { Temperature = 15 };
        Fahrenheit fahrenheit = celsius.ConvertToFahrenheit();

        Console.WriteLine($"{celsius.Temperature} °c => {fahrenheit.Temperature} °f");
        celsius = fahrenheit.ConvertToCelsius();
        Console.WriteLine($"{fahrenheit.Temperature} °f => {celsius.Temperature} °c");
    }
}
