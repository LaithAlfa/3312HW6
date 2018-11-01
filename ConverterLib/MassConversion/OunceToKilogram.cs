namespace ConverterLib.MassConversion
{
    public class OunceToKilogram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 35.274M;
        }
}
}