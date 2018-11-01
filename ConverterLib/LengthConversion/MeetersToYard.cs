namespace ConverterLib.LengthConversion
{
    public class MetersToYard : ILengthConversion
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 1.0936132983M;
        }
    }
}