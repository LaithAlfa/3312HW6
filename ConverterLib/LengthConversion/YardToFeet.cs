namespace ConverterLib.LengthConversion
{
    public class YardsToFeet : ILengthConversion
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 3M;
        }
    }
}