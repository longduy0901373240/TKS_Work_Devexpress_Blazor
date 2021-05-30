using System;
using System.Globalization;

namespace Utility
{
    public class CConst
    {
        public const int INT_VALUE_NULL = 0;
        public const int FLT_VALUE_NULL = 0;
        public const double DB_VALUE_NULL = 0;
        public const string STR_VALUE_NULL = "";
        public static DateTime DTM_VALUE_NULL = DateTime.Parse("01/01/1900 00:00:00", new CultureInfo("fr-FR", true));
        public const int INT_VALUE_ALL = -5;
        public const bool BL_VALUE_NULL = false;
    }
}