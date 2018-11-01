namespace ConverterLib.MassConversion
{
     public class OunceToPound : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 0.062500M;
        }
}
}