using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdvancedOOTopics
{
    abstract class Car
    {
        string fuelType;
        string makeName;
        string driveTrain;

        public Car()
        {

        }
        public Car(string fuelT, string makeN, string driveT)
        {
            fuelType = fuelT;
            makeName = makeN;
            driveTrain = driveT;
        }
        public abstract double ResistanceCoefficient();
    }
}
    
