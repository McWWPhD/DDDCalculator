using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCalculator
{
    public static class DDDCalculator
    {

        public static double CalculateDDD (double dose, int numberOfDoseInThePackage, double DDDinOneDose, int numberOfPackage)
        {
            //( (ILOŚĆ LEKU W 1 TABL./ AMPUŁCE (g)	*	ILOŚĆ TABL./ AMPUŁEK W 1 OPAKOWANIU )	/	DDD DLA 1 TABL./ AMPUŁKI ) * ILOŚĆ ZUŻYTYCH OPAKOWAŃ

            return ((dose * numberOfDoseInThePackage) / DDDinOneDose) * numberOfPackage;

        }        


    }

    //WHO https://www.who.int/medicines/regulation/medicines-safety/toolkit_indicators/en/index1.html
    //int utilization = numberOfPackages * numberOfDDDInThePackage;
    //int denominator = numberOfPatients * numberOfDays;
    //return (utilization / denominator) * 1000;
}
