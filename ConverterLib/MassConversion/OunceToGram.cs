namespace ConverterLib.MassConversion
{
    public class OunceToGram : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn / 0.035274M;
        }
}
}