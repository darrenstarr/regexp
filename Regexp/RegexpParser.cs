﻿// Verophyle.Regexp Copyright © Verophyle Informatics 2015

using System;
using System.Collections.Generic;
using System.Linq;

namespace Verophyle.Regexp
{
    partial class RegexpParser
    {
        int NEXT_POS = 0;

        static char Unescape(IEnumerable<char> chars)
        {
            var str = new string(chars.ToArray());
            if (str == @"\]" || str == @"\+" || str == @"\*")
                return str[1];
            return System.Text.RegularExpressions.Regex.Unescape(str)[0];
        }

        static char UnHex(IEnumerable<char> chars)
        {
            var str = new string(chars.ToArray());
            return (char)Convert.ToInt32(str, 16);
        }
    }
}
