#region Using

using System;

#endregion

namespace DMT
{
    public static class AppConsts
    {
        // common properties
        public static string Version = "1";
        public static string Minor = "5";

        public static class Application
        {
            public static class TA
            {
                public static string ApplicationName = @"DMT Toll Admin Application (Plaza)";
                // common
                public static string Version = AppConsts.Version;
                public static string Minor = AppConsts.Minor;
                public static string Build = "1";
                public static DateTime LastUpdate = new DateTime(2022, 01, 27, 10, 00, 00);
            }

            public static class TOD
            {
                public static string ApplicationName = @"DMT Toll of Duty Application (Plaza)";
                // common
                public static string Version = AppConsts.Version;
                public static string Minor = AppConsts.Minor;
                public static string Build = "1";
                public static DateTime LastUpdate = new DateTime(2022, 01, 27, 10, 00, 00);
            }

            public static class Account
            {
                public static string ApplicationName = @"DMT Toll Admin Application (Account)";
                // common
                public static string Version = AppConsts.Version;
                public static string Minor = AppConsts.Minor;
                public static string Build = "1";
                public static DateTime LastUpdate = new DateTime(2022, 01, 27, 10, 00, 00);
            }

            public static class PlazaConfig
            {
                public static string ApplicationName = @"DMT TOD-TA Plaza Config";
                // common
                public static string Version = AppConsts.Version;
                public static string Minor = AppConsts.Minor;
                public static string Build = "1";
                public static DateTime LastUpdate = new DateTime(2022, 01, 27, 10, 00, 00);
            }

            public static class PlazaSumulator
            {
                public static string ApplicationName = @"DMT TOD-TA Plaza Simulator";
                // common
                public static string Version = AppConsts.Version;
                public static string Minor = AppConsts.Minor;
                public static string Build = "1";
                public static DateTime LastUpdate = new DateTime(2022, 01, 27, 10, 00, 00);
            }

            public static class PlazaWorkBench
            {
                public static string ApplicationName = @"DMT TOD-TA Plaza WorkBench";
                // common
                public static string Version = AppConsts.Version;
                public static string Minor = AppConsts.Minor;
                public static string Build = "1";
                public static DateTime LastUpdate = new DateTime(2022, 01, 27, 10, 00, 00);
            }
        }
    }
}
