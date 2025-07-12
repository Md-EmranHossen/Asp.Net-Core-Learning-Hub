using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtension
    {
        public static int Word_count(this string text)
        {
            text = text.Trim();
            string[] part = text.Split(' ');
            return part.Count(x=> !string.IsNullOrWhiteSpace(x));
        }
    }
}
