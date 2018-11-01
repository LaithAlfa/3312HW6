namespace ConverterLib.LengthConversion
{
    public class FeetToYard : ILengthConversion
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 0.3333333333M;
        }
    }
}