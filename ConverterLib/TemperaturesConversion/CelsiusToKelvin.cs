using System;


namespace ConverterLib.TemperaturesConversion
{
    public class CelsiusToKelvin : ITemperaturesConversion
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn + 273.15M;
        }

    }
}