#region ProblemInfo
// link : 
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterBits
{
    public static partial class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            char[] str = s.ToCharArray();
            for(int i = 0; i < str.Count(); i++)
            {
                if (char.IsUpper(str[i])) str[i] = char.ToLower(str[i]);
                else str[i] = char.ToUpper(str[i]);
            }
            return new string(str);
        }


        public static string ToAltCase(this string Input)
        {
            return String.Join("", Input.ToCharArray().Select(character => Char.IsLower(character) ? Char.ToUpper(character) : Char.ToLower(character)));
        }
   
    }
}
