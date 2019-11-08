using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string source)
        { 
            ///<summary>
            ///Insert spaces before each capital letter in a string
            /// </summary>
            ///<param name="source"></param>
            ///<returns></returns>
            
            string name = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
                name = string.Concat(source.
                Select(x => char.IsWhiteSpace(x) ? 
                x.ToString().Trim() : char.IsUpper(x) ?
                " " + x : x.ToString())).Trim();
            }
            return name;

            //var result = string.Empty;
            //if (!String.IsNullOrWhiteSpace(productName))
            //{
            //    foreach (var letter in productName)
            //    {
            //        if (char.IsUpper(letter))
            //        {
            //            result += " ";
            //        }
            //        result += letter;
            //    }
            //}
            //return result.Trim();
        }
    }
}
