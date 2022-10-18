using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    internal class Logic
    {
        private static double minAngle = 6;
        private static double hoursAngle = 30;
        private static double hoursAngleAfter1Min = 0.5;
        private static double halfOfCircle = 180;
        public static double CalculateLesserAngle(int hours, int min)
        {
            double absoluteMinAngle = min * minAngle;
            double AbsoluteHoursAnlge = hours * hoursAngle + min * hoursAngleAfter1Min;

            var angle = Math.Abs(absoluteMinAngle - AbsoluteHoursAnlge);

            if(angle < halfOfCircle)
            {
                return angle;
            }

            return halfOfCircle * 2 - angle;
        }

        public static Func<int, Boolean> CreateValidationForNumBetweenTwoNums(int min, int max)
        {
            return (num) => num >= min && num <= max;
        }
    }
}
