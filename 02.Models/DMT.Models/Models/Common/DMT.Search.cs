#region Using

using System;
using System.Collections.Generic;
using System.Linq;

using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

// required for JsonIgnore.
using Newtonsoft.Json;
using NLib;
using NLib.Reflection;
using System.Security.Permissions;

#endregion

namespace DMT.Models
{
    #region Search Main class (empty method).

    /// <summary>
    /// The Search class.
    /// </summary>
    public partial class Search { }

    #endregion

    #region Search (Credit)

    static partial class Search
    {
        /// <summary>Credit Searchs.</summary>
        public static partial class Credit
        {
            /// <summary>TSB Credit Searchs.</summary>
            public static partial class TSB
            {

            }
            /// <summary>User Credit Searchs.</summary>
            public static partial class User
            {
                #region Current

                /// <summary>
                /// Gets Current User Credit (By PlazaGroup). 
                /// State is not complted and has No RevenueId.
                /// </summary>
                public class Current : NSearch<Current>
                {
                    #region Public Properties

                    /// <summary>
                    /// Gets or sets User.
                    /// </summary>
                    public Models.User User { get; set; }
                    /// <summary>
                    /// Gets or sets Plaza Group.
                    /// </summary>
                    public Models.PlazaGroup PlazaGroup { get; set; }

                    #endregion

                    #region Static Method (Create)

                    /// <summary>
                    /// Create Search instance.
                    /// </summary>
                    /// <param name="user">The User.</param>
                    /// <param name="plazaGroup">The Plaza Group.</param>
                    /// <returns>Returns Search instance.</returns>
                    public static Current Create(Models.User user,
                        Models.PlazaGroup plazaGroup)
                    {
                        var ret = new Current();
                        ret.User = user;
                        ret.PlazaGroup = plazaGroup;
                        return ret;
                    }

                    #endregion
                }

                #endregion

                #region Completed

                /// <summary>
                /// Gets Completed User Credit (By PlazaGroup). 
                /// State is complted and has No RevenueId.
                /// </summary>
                public class Completed : NSearch<Completed>
                {
                    #region Public Properties

                    /// <summary>
                    /// Gets or sets User.
                    /// </summary>
                    public Models.User User { get; set; }
                    /// <summary>
                    /// Gets or sets Plaza Group.
                    /// </summary>
                    public Models.PlazaGroup PlazaGroup { get; set; }

                    #endregion

                    #region Static Method (Create)

                    /// <summary>
                    /// Create Search instance.
                    /// </summary>
                    /// <param name="user">The User.</param>
                    /// <param name="plazaGroup">The Plaza Group.</param>
                    /// <returns>Returns Search instance.</returns>
                    public static Completed Create(Models.User user,
                        Models.PlazaGroup plazaGroup)
                    {
                        var ret = new Completed();
                        ret.User = user;
                        ret.PlazaGroup = plazaGroup;
                        return ret;
                    }

                    #endregion
                }

                #endregion
            }
        }
    }

    #endregion

    #region Search (Coupon)

    static partial class Search
    {
        /// <summary>Coupon Searchs.</summary>
        public static partial class Coupon
        {
            /// <summary>TSB Coupon Searchs.</summary>
            public static partial class TSB
            {

            }

            /// <summary>User Coupon Searchs.</summary>
            public static partial class User
            {
                #region Current

                /// <summary>
                /// Gets User Coupon Sold Balance. 
                /// </summary>
                public class Sold : NSearch<Sold>
                {
                    #region Public Properties

                    /// <summary>
                    /// Gets or sets PlazaGroup.
                    /// </summary>
                    public Models.PlazaGroup PlazaGroup { get; set; }
                    /// <summary>
                    /// Gets or sets User.
                    /// </summary>
                    public Models.User User { get; set; }
                    /// <summary>
                    /// Gets or sets Start Time (to check SoldDate).
                    /// </summary>
                    public DateTime? Start { get; set; }
                    /// <summary>
                    /// Gets or sets End Time (to check SoldDate).
                    /// </summary>
                    public DateTime? End { get; set; }

                    #endregion

                    #region Static Method (Create)

                    /// <summary>
                    /// Create Search instance.
                    /// </summary>
                    /// <param name="usplazaGrouper">The PlazaGroup.</param>
                    /// <param name="user">The User.</param>
                    /// <param name="start">The Start Time (to check SoldDate).</param>
                    /// <param name="end">The End Time (to check SoldDate).</param>
                    /// <returns>Returns Search instance.</returns>
                    public static Sold Create(Models.PlazaGroup plazaGroup, Models.User user, DateTime? start, DateTime? end)
                    {
                        var ret = new Sold();
                        ret.PlazaGroup = plazaGroup;
                        ret.User = user;
                        ret.Start = start;
                        ret.End = end;
                        return ret;
                    }

                    #endregion
                }

                #endregion
            }
        }
    }


    #endregion
}
