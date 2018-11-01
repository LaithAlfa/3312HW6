using System;

namespace ConverterLib.TemperaturesConversion
{
    public class KelvinToCelsius : ITemperaturesConversion
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn - 273.15M;
        }
    }
}