using System;

namespace Transportation
{
    public class Transpo
    {
        public string GetMake { get; set; }
        public string GetModel { get; set; }
        public string GetColor { get; set; }
        public string GetYear { get; set; }
        public string GetNumWheel { get; set; }
        public string GetEngineSize { get; set; }

        public int GetMPH(int value)
        {
            return value;
        }

        public int GetMPG(int value, int value1)
        {
            int mpg = value * value1;
            return mpg;
        }

        public string GetWear(int miles, int temp, int tread)
        {
            string condition = " ";
            if (temp != 0)
            {
                int calcOne = (miles*4) / temp;
                double calcTwo = tread * .5;
                if (calcOne < calcTwo)
                {
                    condition = "Unsafe";
                }
                else
                {
                    condition = "Safe";
                }
            }
            else
            {
                condition = "Invalid Entry";
            }

            return condition;
        }
    }
}