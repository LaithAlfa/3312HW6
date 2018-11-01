using System;

namespace ConverterLib.TemperaturesConversion
{
    public class CelsiusToFahrenheit : ITemperaturesConversion
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn * (9M / 5M) + 32;
        }
    }
}