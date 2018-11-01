using System;

namespace ConverterLib.TemperaturesConversion
{
    public class FahrenheitToCelsius : ITemperaturesConversion
    {
        public decimal GetTemp(decimal tempIn)
        {
            return (tempIn - 32) / 9M * 5M;
        }
    }
}