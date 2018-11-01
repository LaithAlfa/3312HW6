using System;
using ConverterLib.TemperaturesConversion;
using ConverterLib.LengthConversion;
using ConverterLib.MassConversion;

namespace ConverterClient
{
    class Program
    {
         static void Main(string[] args)
        {
            
            // Length Conversions

            Console.WriteLine("Length Conversions");

            ILengthConversion fToM = new FeetToMeters();
            ILengthConversion mToF = new MetersToFeet();
            ILengthConversion fToY = new FeetToYard();
            ILengthConversion yToF = new YardsToFeet();
            ILengthConversion yToM = new YardsTometers();
            ILengthConversion mToY = new MetersToYard();

            Console.WriteLine(Math.Round(fToM.GetLength(25), 2));
            Console.WriteLine(Math.Round(mToF.GetLength(25), 2));
            Console.WriteLine(Math.Round(fToY.GetLength(25), 2));
            Console.WriteLine(Math.Round(yToF.GetLength(25), 2));
            Console.WriteLine(Math.Round(yToM.GetLength(25), 2));
            Console.WriteLine(Math.Round(mToY.GetLength(25), 2));

         // Mass Conversions

            Console.WriteLine("Mass Conversions");
            IMassConversions gToK = new GramToKilograms();
            IMassConversions kToG = new KilogramToGram();
            IMassConversions gToO = new GramToOunce();
            IMassConversions oToG = new OunceToGram();
            IMassConversions gToP = new GramToPound();
            IMassConversions pToG = new PoundToGram();
            IMassConversions pToO = new PoundToOunce();
            IMassConversions oToP = new OunceToPound();
            IMassConversions kToO = new KilogramToOunce();
            IMassConversions oToK = new OunceToKilogram();
            IMassConversions pToK = new PoundToKilogram();
            IMassConversions kToP = new KilogramToPound();

            Console.WriteLine(Math.Round(gToK.GetMass(50), 2));
            Console.WriteLine(Math.Round(kToG.GetMass(50), 2));
            Console.WriteLine(Math.Round(gToO.GetMass(50), 2));
            Console.WriteLine(Math.Round(oToG.GetMass(50), 2));
            Console.WriteLine(Math.Round(gToP.GetMass(50), 2));
            Console.WriteLine(Math.Round(pToG.GetMass(50), 2));
            Console.WriteLine(Math.Round(pToO.GetMass(50), 2));
            Console.WriteLine(Math.Round(oToP.GetMass(50), 2));
            Console.WriteLine(Math.Round(kToO.GetMass(50), 2));
            Console.WriteLine(Math.Round(oToK.GetMass(50), 2));
            Console.WriteLine(Math.Round(pToK.GetMass(50), 2));
            Console.WriteLine(Math.Round(kToP.GetMass(50), 2));

            // TemperaturesConversion

            Console.WriteLine("Temperature Conversions");

           
            ITemperaturesConversion cToF = new CelsiusToFahrenheit();
            ITemperaturesConversion fToC = new FahrenheitToCelsius();
            ITemperaturesConversion cToK = new CelsiusToKelvin();
            ITemperaturesConversion kToC = new KelvinToCelsius();
            ITemperaturesConversion fToK = new FahernheitToKelvin();
            ITemperaturesConversion kToF = new KelvinToFahrenheit();

           
            Console.WriteLine(Math.Round(cToF.GetTemp(15), 2));
            Console.WriteLine(Math.Round(fToC.GetTemp(15), 2));
            Console.WriteLine(Math.Round(cToK.GetTemp(15), 2));
            Console.WriteLine(Math.Round(kToC.GetTemp(15), 2));
            Console.WriteLine(Math.Round(fToK.GetTemp(15), 2));
            Console.WriteLine(Math.Round(kToF.GetTemp(15), 2));

            Console.WriteLine();


           
        }
    }
}
