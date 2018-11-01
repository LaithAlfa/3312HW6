namespace ConverterLib.LengthConversion
{
    public class MetersToFeet : ILengthConversion
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn / 0.3048M;
        }
    }
}