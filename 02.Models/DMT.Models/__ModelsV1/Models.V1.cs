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

#region Configuration (3/3)

namespace DMT.Models.V1
{
	#region AppOption (OK)

	/// <summary>
	/// The AppOption class.
	/// </summary>
	[Serializable, JsonObject(MemberSerialization.OptOut)]
	public class AppOption : NTable<AppOption>
	{
		#region Public Properties (OK)

		/// <summary>
		/// Gets or sets key (used as primary key).
		/// </summary>
		[PrimaryKey, MaxLength(80)]
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets value.
		/// </summary>
		[MaxLength(200)]
		public string Value { get; set; }

		#endregion
	}

	#endregion

	#region AppOption Extension Method(s) (OK)

	/// <summary>
	/// The AppOption Extension Methods
	/// </summary>
	public static class AppOptionExtensionMethods
	{
		#region ToDateTime

		/// <summary>
		/// Convert AppOption's value to datetime.
		/// </summary>
		/// <param name="inst">The AppOption instance.</param>
		/// <returns>Returns AppOption's value in DateTime instance.</returns>
		public static DateTime? ToDateTime(this AppOption inst)
		{
			MethodBase med = MethodBase.GetCurrentMethod();
			DateTime? ret = new DateTime?();
			if (null != inst && !string.IsNullOrWhiteSpace(inst.Value))
			{
				try
				{
					string[] parts = inst.Value.Split(new char[] { ':', '-', '.', 'T', '/', '\\', ',', ' ', ';' },
						StringSplitOptions.RemoveEmptyEntries);

					int yr = DateTime.MinValue.Year;
					int mn = DateTime.MinValue.Month;
					int dy = DateTime.MinValue.Day;
					int val;
					int hr = 12;
					if (parts.Length > 0)
					{
						if (int.TryParse(parts[0], out val) && (val >= 0 && val <= 23))
						{
							hr = val;
						}
						else
						{
							// Parse Error, out of range.
							val = 12;
							med.Err("Hour: Parse error or out of range. Used default Hour = 12.");
						}
					}

					int min = 0;
					if (parts.Length > 1)
					{
						if (int.TryParse(parts[1], out val) && (val >= 0 && val <= 59))
						{
							min = val;
						}
						else
						{
							// Parse Error, out of range.
							val = 0;
							med.Err("Minute: Parse error or out of range. Used default Minute = 0.");
						}
					}

					int sec = 0;
					if (parts.Length > 2)
					{
						if (int.TryParse(parts[2], out val) && (val >= 0 && val <= 59))
						{
							sec = val;
						}
						else
						{
							// Parse Error, out of range.
							val = 0;
							med.Err("Second: Parse error or out of range. Used default Second = 0.");
						}
					}

					int msec = 0;
					if (parts.Length > 3)
					{
						if (int.TryParse(parts[3], out val) && (val >= 0 && val <= 999))
						{
							msec = val;
						}
						else
						{
							// Parse Error, out of range.
							val = 0;
							med.Err("Millisecond: Parse error or out of range. Used default Millisecond = 0.");
						}
					}

					DateTime dt = new DateTime(yr, mn, dy, hr, min, sec, msec);
					ret = new DateTime?(dt);
				}
				catch (Exception ex)
				{
					med.Err(ex);
					ret = new DateTime?();
				}
			}

			return ret;
		}

		#endregion
	}

	#endregion

	#region UniqueCode (OK)

	/// <summary>
	/// The UniqueCode class.
	/// </summary>
	[Serializable, JsonObject(MemberSerialization.OptOut)]
	public class UniqueCode : NTable<UniqueCode>
	{
		#region Reset Mode Enum (OK)

		/// <summary>
		/// Reset Mode Enum
		/// </summary>
		public enum ResetMode
		{
			/// <summary>Reset Yearly.</summary>
			Yearly = 1,
			/// <summary>Reset Monthly.</summary>
			Monthly = 2
		}

		#endregion

		#region Public Properties (OK)

		/// <summary>
		/// Gets or sets Key (used as primary key).
		/// </summary>
		[PrimaryKey, MaxLength(50)]
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets reset mode.
		/// </summary>
		[NotNull]
		public ResetMode Mode { get; set; }
		/// <summary>
		/// Gets or sets Prefix
		/// </summary>
		[MaxLength(30)]
		public string Prefix { get; set; }
		/// <summary>
		/// Gets or sets last number.
		/// </summary>
		[NotNull]
		public int LastNumber { get; set; }
		/// <summary>
		/// Gets or sets Last Update
		/// </summary>
		[NotNull]
		public DateTime? LastUpdate { get; set; }

		#endregion
	}

	#endregion

	#region ViewHistory (OK)

	/// <summary>
	/// The ViewHistory class.
	/// </summary>
	[Serializable, JsonObject(MemberSerialization.OptOut)]
	public class ViewHistory : NTable<ViewHistory>
	{
		#region Public Properties (OK)

		/// <summary>
		/// Gets or sets ViewName (used as primary key).
		/// </summary>
		[PrimaryKey, MaxLength(100)]
		public string ViewName { get; set; }
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		[NotNull]
		public int VersionId { get; set; }

		#endregion
	}

	#endregion
}

#endregion

#region User

namespace DMT.Models.V1
{

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
