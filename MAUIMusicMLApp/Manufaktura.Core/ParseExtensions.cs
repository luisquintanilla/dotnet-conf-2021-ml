using System;
using System.Globalization;

namespace Manufaktura.Core
{
    public static class ParseExtensions
    {
        public static double? TryParse(string s)
        {
            double result;
            if (double.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out result)) return result;
            return null;
        }

        public static DateTime? TryParseDateTime(string s)
        {
            DateTime result;
            if (DateTime.TryParse(s, out result)) return result;
            return null;
        }

        public static int? TryParseInt(string s)
        {
            int result;
            if (int.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out result)) return result;
            return null;
        }
    }
}