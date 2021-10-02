﻿namespace DMT
{
    static partial class RouteConsts
    {
        static partial class TOD
        {
            static partial class Infrastructure
            {
                static partial class TSB
                {
                    /// <summary>The Gets Current (Active) TSB action.</summary>
                    public static class Current
                    {
                        /// <summary>Gets route name.</summary>
                        public const string Name = "Current";
                        /// <summary>Gets route url.</summary>
                        public const string Url = TSB.Url + @"/" + Name;
                    }
                }
            }
        }
    }
}
