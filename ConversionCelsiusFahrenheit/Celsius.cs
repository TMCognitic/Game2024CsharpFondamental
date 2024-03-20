namespace ConversionCelsiusFahrenheit;

struct Celsius
{
    public double Temperature;

    public Fahrenheit ConvertToFahrenheit()
    {
        Fahrenheit fahrenheit = new Fahrenheit();
        fahrenheit.Temperature = Temperature * 1.8 + 32;
        return fahrenheit;

        //return new Fahrenheit() { Temperature = Temperature * 1.8 + 32 };
    }
}
