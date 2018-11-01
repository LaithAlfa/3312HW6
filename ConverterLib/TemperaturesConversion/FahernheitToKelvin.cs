using System;

namespace ConverterLib.TemperaturesConversion
{
    public class FahernheitToKelvin : ITemperaturesConversion
    {
        public decimal GetTemp(decimal tempIn)
        {
            return (tempIn + 459.67M) * 5M / 9M;
        }
    }
}