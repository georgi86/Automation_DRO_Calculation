using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DRO
{
    public class ReportAction
    {
        public static void RunPositiveReport(double dActual)
        {
            string ActualVAlue = "Actual Value is :" + dActual;
            Ranorex.Report.Success("Sucessfully performed");
        }

        public static void RunNegativeReport(double dActual, double dHardcoded)
        {
            string ActualValue = "Actual Value is: " + dActual;
            Ranorex.Report.Error(ActualValue);

            string HardcodedValue = "Hardcoded VAlue is: " + dHardcoded;
            Ranorex.Report.Error(HardcodedValue);
        }
    }

    public class Mathematics
    {

        public static bool Calculation(double Expresion, double Epsilone)
        {
            bool bRes1 = (System.Math.Abs(Expresion) < Epsilone);

            return bRes1;

        }
        public static bool PreparingForCalculation(double actual, double hardcoded, double Epsilone)
        {
            bool bRes2 = Calculation(actual - hardcoded, Epsilone);

            return bRes2; 
        }

    }
    public class ComparingDROValues
    {
        public static void DROValueInch(string Hardcoded, string Actual)
        {
            string ActualValueInch = Actual;
            string HardcodedVAlueInch = Hardcoded;

            bool ExpectedDeviation = true;

            double dActualValue;
            double dHardcodedValue;
            Double.TryParse(ActualValueInch, out dActualValue);
            Double.TryParse(HardcodedVAlueInch, out dHardcodedValue);

            try
            {
                if (!Mathematics.PreparingForCalculation(dActualValue, dHardcodedValue, 0.003))
                {
                    ExpectedDeviation = false;

                    ReportAction.RunNegativeReport(dActualValue, dHardcodedValue);

                }
            }
            catch (Exception)
            {

            }

            if (ExpectedDeviation)
            {
                ReportAction.RunPositiveReport(dActualValue);
            }
        }

        public static void DROValue(string HardcodedInParam, string ActualInParam)
        {
            string ActualValue = ActualInParam;
            string HardcodedValue = HardcodedInParam;

            bool bVerySimilarValues = false;

            double dActualValue;
            double dHardcodedValue;
            Double.TryParse(ActualValue, out dActualValue);
            Double.TryParse(HardcodedValue, out dHardcodedValue);

            try
            {
                bVerySimilarValues = Mathematics.PreparingForCalculation(dActualValue, dHardcodedValue, 0.070);

                if (! bVerySimilarValues)
                {
                    ReportAction.RunNegativeReport(dActualValue, dHardcodedValue);                    
                }
               
            }
            catch(Exception)
            {

            }

            if (bVerySimilarValues)
            {
                ReportAction.RunPositiveReport(dActualValue);
            }
       }
    }
}

        

           
           
            
            

        
    

