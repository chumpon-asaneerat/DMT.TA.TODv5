#region Using

using System.ComponentModel;
using NLib;

// required for JsonIgnore attribute.
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

#endregion

namespace DMT.Models
{
    #region DMTModelBase (abstract)

    /// <summary>
    /// The DMTModelBase abstract class.
    /// </summary>
    public abstract class DMTModelBase : NInpc
    {
    }

    #endregion
}
