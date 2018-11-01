namespace ConverterLib.MassConversion
{
    public class GramToKilograms : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 1000M;
        }
    }
}