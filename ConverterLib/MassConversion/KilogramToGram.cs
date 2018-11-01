namespace ConverterLib.MassConversion
{
   public class KilogramToGram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 1000M;
        }
    }
}