namespace ConverterLib.LengthConversion
{
    public class FeetToMeters : ILengthConversion
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 3.2808M;
        }
    }
}