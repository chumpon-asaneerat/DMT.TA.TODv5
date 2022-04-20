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

#region Master Tables - (5/5)

namespace DMT.Models.V1
{
	#region MActiveStatus (OK)

	/// <summary>
	/// The MActiveStatus enum.
	/// </summary>
	public enum MActiveStatus
	{
		/// <summary>None (or inactive) status.</summary>
		None = 0,
		/// <summary>Active status.</summary>
		Active = 1
	}

	#endregion

	#region MCardAllow (OK)

	/// <summary>
	/// The MCardAllow class.
	/// </summary>
	[Serializable, JsonObject(MemberSerialization.OptOut)]
	public class MCardAllow : NTable<MCurrency>
	{
		#region Public Properties (OK)

		/// <summary>
		/// Gets or sets primary key.
		/// </summary>
		[PrimaryKey]
		public int cardAllowId { get; set; }
		/// <summary>
		/// Gets or sets abbreviation.
		/// </summary>
		[MaxLength(50)]
		public string abbreviation { get; set; }
		/// <summary>
		/// Gets or sets description.
		/// </summary>
		[MaxLength(100)]
		public string description { get; set; }
		/// <summary>
		/// Gets or sets active status.
		/// </summary>
		public MActiveStatus ActiveStatus { get; set; }

		#endregion
	}

	#endregion

	#region MCoupon (OK)

	/// <summary>
	/// The MCoupon class.
	/// </summary>
	[Serializable, JsonObject(MemberSerialization.OptOut)]
	public class MCoupon : NTable<MCoupon>
	{
		#region Public Properties (OK)

		/// <summary>
		/// Gets or sets primary key.
		/// </summary>
		[PrimaryKey]
		public int couponId { get; set; }
		/// <summary>
		/// Gets or seets couponValue.
		/// </summary>
		public decimal couponValue { get; set; }
		/// <summary>
		/// Gets or sets abbreviation.
		/// </summary>
		[MaxLength(50)]
		public string abbreviation { get; set; }
		/// <summary>
		/// Gets or sets description.
		/// </summary>
		[MaxLength(100)]
		public string description { get; set; }
		/// <summary>
		/// Gets or sets active status.
		/// </summary>
		public MActiveStatus ActiveStatus { get; set; }

		#endregion
	}

	#endregion

	#region MCouponBook (OK)

	/// <summary>
	/// The MCouponBook class.
	/// </summary>
	[Serializable, JsonObject(MemberSerialization.OptOut)]
	public class MCouponBook : NTable<MCouponBook>
	{
		#region Public Properties (OK)

		/// <summary>
		/// Gets or sets primary key.
		/// </summary>
		[PrimaryKey]
		public int couponBookId { get; set; }
		/// <summary>
		/// Gets or seets couponBookValue.
		/// </summary>
		public decimal couponBookValue { get; set; }
		/// <summary>
		/// Gets or sets abbreviation.
		/// </summary>
		[MaxLength(50)]
		public string abbreviation { get; set; }
		/// <summary>
		/// Gets or sets description.
		/// </summary>
		[MaxLength(100)]
		public string description { get; set; }
		/// <summary>
		/// Gets or sets active status.
		/// </summary>
		public MActiveStatus ActiveStatus { get; set; }

		#endregion
	}

	#endregion

	#region MCurrency (OK)

	/// <summary>
	/// The MCurrency class.
	/// </summary>
	[Serializable, JsonObject(MemberSerialization.OptOut)]
	public class MCurrency : NTable<MCurrency>
	{
		#region Public Properties (OK)

		/// <summary>
		/// Gets or sets primary key.
		/// </summary>
		[PrimaryKey]
		public int currencyDenomId { get; set; }
		/// <summary>
		/// Gets or seets currencyId.
		/// </summary>
		public int currencyId { get; set; }
		/// <summary>
		/// Gets or sets denomTypeId.
		/// </summary>
		public int denomTypeId { get; set; }
		/// <summary>
		/// Gets or sets denomValue.
		/// </summary>
		public decimal denomValue { get; set; }
		/// <summary>
		/// Gets or sets abbreviation.
		/// </summary>
		[MaxLength(50)]
		public string abbreviation { get; set; }
		/// <summary>
		/// Gets or sets description.
		/// </summary>
		[MaxLength(100)]
		public string description { get; set; }
		/// <summary>
		/// Gets or sets active status.
		/// </summary>
		public MActiveStatus ActiveStatus { get; set; }

		#endregion
	}

	#endregion
}

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
