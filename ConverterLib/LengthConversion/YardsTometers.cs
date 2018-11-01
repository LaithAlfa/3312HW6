namespace ConverterLib.LengthConversion
{
    public class YardsTometers : ILengthConversion
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 0.9144M;
        }
    }
}