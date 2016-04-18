using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterBits
{
    public partial class StringExt
    {
        public static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            var difFirst = str1.ToCharArray().Except(str2.ToCharArray());
            var difSecond = str2.ToCharArray().Except(str1.ToCharArray());
            if (difFirst.Any() || difSecond.Any()) return false;
            return true;
        }
    }
}
