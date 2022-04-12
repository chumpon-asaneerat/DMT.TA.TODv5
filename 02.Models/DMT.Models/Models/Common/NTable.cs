#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;
using System.ComponentModel;
//using DMT.Services;
// required for JsonIgnore.
using Newtonsoft.Json;
using NLib;
using NLib.Reflection;
using System.Reflection;

#endregion

namespace DMT.Models
{
    #region NTable

    /// <summary>
    /// The NTable abstract class.
    /// </summary>
    public abstract class NTable : DMTModelBase
    {
        #region Static Variables and Properties

        /// <summary>
        /// sync object used for lock concurrent access.
        /// </summary>
        protected static object sync = new object();
        /// <summary>
        /// Gets default Connection.
        /// </summary>
        public static SQLiteConnection Default { get; set; }

        #endregion
    }

    #endregion

    #region NTable<T>

    /// <summary>
    /// The NTable (Generic) abstract class.
    /// </summary>
    /// <typeparam name="T">The Target Class.</typeparam>
    public abstract class NTable<T> : NTable
        where T : NTable, new()
    {
        #region Static Methods

        #region Create

        /// <summary>
        /// Create new instance.
        /// </summary>
        /// <returns>Returns new instance.</returns>
        public static T Create()
        {
            return new T();
        }

        #endregion

        #endregion
    }

    #endregion


    #region IFKs interface

    /// <summary>
    /// The IFKs interface of T.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    public interface IFKs<T>
        where T : NTable, new()
    {
    }

    #endregion
}
