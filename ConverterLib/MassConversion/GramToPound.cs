namespace ConverterLib.MassConversion
{
     public class GramToPound : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 0.0022046M;
        }
}
}