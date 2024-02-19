
namespace NUnitDemonstration1
{


    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            string result;

            // Mutated code where == is replaced by !=)
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}
