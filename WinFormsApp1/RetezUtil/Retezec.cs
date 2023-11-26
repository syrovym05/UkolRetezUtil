using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetezUtil
{
    public class Retezec
    {

        /// <summary>
        /// Metoda Smaž
        ///  - smaže všechna čísla ve vstupu
        /// </summary>
        /// <param name="s">Řetězec string</param>
        /// <returns>Opravený řetězec</returns>

        static public string Smaz(string s)
        {
            string cislice = "0123456789";
            for (int i = 0; i < s.Length; i++)
            {
                if (cislice.Contains(s[i]))
                {
                    s = s.Remove(i,1);
                    i--;
                }
            }

            return s;
        }


        static public string Zobraz(string s)
        {
            return s;
        }

    }
}
