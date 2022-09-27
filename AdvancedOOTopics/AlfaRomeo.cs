using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdvancedOOTopics
{
    class AlfaRomeo : Car
    {
        string colorName;
        string modelName;

        public AlfaRomeo(string fuelT, string makeN, string driveT, string colorN, string modelN)
           : base(fuelT, makeN, driveT)
        {
            colorName = colorN;
            modelName = modelN;
        }
        public override double ResistanceCoefficient()
        {
            double rCoeff = 0.99;
            return rCoeff;
        }
    }
}
