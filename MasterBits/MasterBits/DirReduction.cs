#region ProblemInfo
// link : http://www.codewars.com/kata/550f22f4d758534c1100025a
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace MasterBits
{
    public class DirReduction
    {
        public static string[] DirReduc(String[] arr)
        {
            for (int i = 0; i < arr.Length - 1;)
            {
                List<string> arrStr = arr.ToList();
                string toCompare = arr[i] + " " + arr[i + 1];
                if (toCompare == "EAST WEST" || toCompare == "WEST EAST" || toCompare == "SOUTH NORTH" ||
                    toCompare == "NORTH SOUTH")
                {
                    arrStr.RemoveAt(i);
                    arrStr.RemoveAt(i);
                    arr = arrStr.ToArray();
                    if (i > 0) i--;
                }
                else i++;
            }
            return arr;
        }

        public static string[] DirReduc2(string[] arr)
        {
            string s = new string(arr.Select(x => x[0]).ToArray());
            while (Regex.Match(s, "NS|EW|SN|WE").Success) s = Regex.Replace(s, "NS|EW|SN|WE", "");
            return s.Select(x => x == 'N' ? "NORTH" : x == 'S' ? "SOUTH" : x == 'E' ? "EAST" : "WEST").ToArray();
        }
    }
}