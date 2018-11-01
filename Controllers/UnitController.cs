using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
using ConverterLib.TemperaturesConversion;
using ConverterLib.LengthsConversion;
using ConverterLib.MassConversion;


     public class ConverterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
      public IActionResult TempConvert(decimal numIn)
        {
            // Instantiate new objects that implement ITempConversions
            ITemperaturesConversion cToF = new CelsiusToFahrenheit();
            ITemperaturesConversion fToC = new FahrenheitToCelsius();
            ITemperaturesConversion cToK = new CelsiusToKelvin();
            ITemperaturesConversion kToC = new KelvinToCelsius();
            ITemperaturesConversion fToK = new FahrenheToKelvin();
            ITemperaturesConversion kToF = new KelvinToFahrenheit();

            ViewData["NumberInput"] = numIn;
            ViewData["CtoF"] = Math.Round(cToF.GetTemp(numIn), 2);
            ViewData["FtoC"] = Math.Round(fToC.GetTemp(numIn), 2);
            ViewData["CtoK"] = Math.Round(cToK.GetTemp(numIn), 2);
            ViewData["KtoC"] = Math.Round(kToC.GetTemp(numIn), 2);
            ViewData["FtoK"] = Math.Round(fToK.GetTemp(numIn), 2);
            ViewData["KtoF"] = Math.Round(kToF.GetTemp(numIn), 2);
            return View();
        }

        public IActionResult LengthConvert(decimal numIn)
        {
            ILengthConversion mToF = new MetersToFeet();
            ILengthConversion fToM = new FeetToMeter();
            ILengthConversion mToY = new MetersToYard();
            ILengthConversion yToM = new YardToMeter();
            ILengthConversion fToY = new FeetToYard();
            ILengthConversion yToF = new YardToFeet();

            ViewData["NumInput"] = numIn;
            ViewData["MtoF"] = Math.Round(mToF.GetLength(numIn), 2);
            ViewData["FtoM"] = Math.Round(fToM.GetLength(numIn), 2);
            ViewData["MtoY"] = Math.Round(mToY.GetLength(numIn), 2);
            ViewData["YtoM"] = Math.Round(yToM.GetLength(numIn), 2);
            ViewData["FtoY"] = Math.Round(fToY.GetLength(numIn), 2);
            ViewData["YtoF"] = Math.Round(yToF.GetLength(numIn), 2);

            return View();
        }

        public IActionResult MassConvert(decimal numIn)
        {
            IMassConversions gToK = new GramToKilograms();
            IMassConversions kToG = new KilogramToGram();
            IMassConversions gToO = new GramToOunce();
            IMassConversions oToG = new OunceToGram();
            IMassConversions gToP = new GramToPound();
            IMassConversions pToG = new PoundToGram();
            IMassConversions pToO = new PoundToOunce();
            IMassConversions oToP = new OunceToPounds();
            IMassConversions kToO = new KilogramToOunce();
            IMassConversions oToK = new OunceToKilogram();
            IMassConversions pToK = new PoundToKilogram();
            IMassConversions kToP = new KilogramToPound();

            ViewData["NumInput"] = numIn;
            ViewData["OtoL"] = Math.Round(oToP.GetMass(numIn), 2);
            ViewData["LtoO"] = Math.Round(pToO.GetMass(numIn), 2);
            ViewData["OtoG"] = Math.Round(oToG.GetMass(numIn), 2);
            ViewData["GtoO"] = Math.Round(gToO.GetMass(numIn), 2);
            ViewData["OtoK"] = Math.Round(oToK.GetMass(numIn), 2);
            ViewData["KtoO"] = Math.Round(kToO.GetMass(numIn), 2);
            ViewData["LtoG"] = Math.Round(pToG.GetMass(numIn), 2);
            ViewData["GtoL"] = Math.Round(gToP.GetMass(numIn), 2);
            ViewData["LtoK"] = Math.Round(pToK.GetMass(numIn), 2);
            ViewData["KtoL"] = Math.Round(kToP.GetMass(numIn), 2);
            ViewData["GtoK"] = Math.Round(gToK.GetMass(numIn), 2);
            ViewData["KtoG"] = Math.Round(kToG.GetMass(numIn), 2);

            return View();
        }
    }
