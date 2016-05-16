using System;
using System.Diagnostics;

namespace RRRControl
{
    public class Utilities
    {

        public static String MapGear(Int32 gear) {

            //TODO pass from Map to ENUM if you don't need to do any calculation

            if (gear == -1)
            {
                return "R";
            }
            else if (gear == 0) {
                return "N";
            }
            else if (gear == -2) {
                return "E";
            }
            

            return gear.ToString();
        }

        public static Single RpsToRpm(Single rps)
        {
            return rps * (60 / (2 * (Single)Math.PI));
        }

        public static Single RpsToRpmtoangle(Single rps,Single rpsm, Single maxGrad)
        {
            return (rps * maxGrad) / rpsm;
        }

        public static Single MpsToKph(Single mps)
        {
            return mps * 3.6f;
        }

        public static Single RadToGrad(Single rad)
        {
            return rad * (180 / (Single)Math.PI);
        }

        public static Single Mapto(Single map,int maxDegree)
        {
            return  Convert.ToInt16(maxDegree * map);
        }

        public static bool IsRrreRunning()
        {
            return Process.GetProcessesByName("RRRE").Length > 0;
        }

        public static Int16 BrakeBias(Single postPercentage, Char selectedData ) {

            if (postPercentage > 0) {

                if (selectedData == 'r') {
                    return (Int16)(postPercentage * 100);
                } else if (selectedData == 'f') {
                    return (Int16)((1 - postPercentage) * 100);
                }

            }


            return 0;

        }

    }
}