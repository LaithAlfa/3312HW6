using System;

namespace ConverterLib.TemperaturesConversion
{
      public class KelvinToFahrenheit : ITemperaturesConversion
        {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn * (9M / 5M) - 459.67M;
        }
    }
}