using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Shared
    {

        public int Add(string number)
        {
            if (string.IsNullOrEmpty(number) ||string.IsNullOrEmpty(number.Trim()))
            {
                return 0;              
            }
            else
            {
                number = number.Replace("\n", ",");
                int returnValue = 0;
                string[] pisesString = number.Split(',');
                foreach (string pieace in pisesString)
                {
                    if (!string.IsNullOrEmpty(pieace) && !string.IsNullOrEmpty(pieace.Trim()))
                    {
                        int pieceInt = 0;
                        if (int.TryParse(pieace, out pieceInt))
                        {
                            returnValue += pieceInt;
                        }
                    }
                }

                return returnValue;
            }
            
        }


    }
}
