using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtensionsStructEnum
{
    //3. String uchun extension yazin (uzun bir text olsun),
    //Hansiki bu cumledeki Uppercase-le bashlayan sozleri array-e doldurub qaytarsin
    public static class Extensions
    {
        public static bool IsFirstCharUpper(this string str)
        {
            return char.IsUpper(str, 0);
        }

        public static double GetPower(this double number, double power)
        {
            return Math.Pow(number, power);
        }

        public static int[] AddElement(this int[] arr, int element)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = element;

            return arr;
        }
    }
}
