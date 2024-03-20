namespace ConversionCelsiusFahrenheit;

struct Fahrenheit
{
    public double Temperature;

    public Celsius ConvertToCelsius()
    {
        return new Celsius() { Temperature = (Temperature - 32) / 1.8 };
    }
}
