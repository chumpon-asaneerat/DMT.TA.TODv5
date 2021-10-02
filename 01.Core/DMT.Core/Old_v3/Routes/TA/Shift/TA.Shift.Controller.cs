﻿namespace DMT
{
    static partial class RouteConsts
    {
        partial class TA
        {
            /// <summary>The Shift Controller.</summary>
            public static partial class Shift
            {
                /// <summary>Gets controller name.</summary>
                public const string ControllerName = "TAAShift";

                /// <summary>Gets route name.</summary>
                public const string Name = "Shift";
                /// <summary>Gets base controller url.</summary>
                public const string Url = TA.Url + @"/" + Name;

                // Url: api/taashift/tsb
                /// <summary>The Shift's TSB Controller.</summary>
                public static partial class TSB
                {
                    /// <summary>Gets controller name.</summary>
                    public const string ControllerName = "TAATSBShiftManage";

                    /// <summary>Gets route name.</summary>
                    public const string Name = "TSB";
                    /// <summary>Gets route url.</summary>
                    public const string Url = Shift.Url + @"/" + Name;
                }

                // Url: api/taashift/user
                /// <summary>The Shift's User Controller.</summary>
                public static partial class User
                {
                    /// <summary>Gets controller name.</summary>
                    public const string ControllerName = "TAAUserShiftManage";

                    /// <summary>Gets route name.</summary>
                    public const string Name = "User";
                    /// <summary>Gets route url.</summary>
                    public const string Url = Shift.Url + @"/" + Name;
                }
            }
        }
    }
}
