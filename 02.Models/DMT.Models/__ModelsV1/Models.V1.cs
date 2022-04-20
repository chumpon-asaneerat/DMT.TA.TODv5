#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using NLib;
using NLib.Design;
using NLib.Reflection;

using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;
// required for JsonIgnore attribute.
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.Reflection;

#endregion

#region Common (1/1)

namespace DMT.Models.V1
{
	#region IsAliveResult (OK)

	/// <summary>
	/// The IsAliveResult Model Class.
	/// </summary>
	[Serializable, JsonObject(MemberSerialization.OptOut)]
	public class IsAliveResult
	{
		#region Public Properties (OK)

		/// <summary>
		/// Gets or sets Time Stamp.
		/// </summary>
		public DateTime? TimeStamp { get; set; }

		#endregion
	}

	#endregion
}

#endregion

#region Shift

namespace DMT.Models.V1
{

}

#endregion

#region Infrastructures

namespace DMT.Models.V1
{

}

#endregion

#region Coupon

namespace DMT.Models.V1
{

}

#endregion

#region Credit

namespace DMT.Models.V1
{

}

#endregion

#region Revenue

namespace DMT.Models.V1
{

}

#endregion

#region Exchange

namespace DMT.Models.V1
{

}

#endregion
