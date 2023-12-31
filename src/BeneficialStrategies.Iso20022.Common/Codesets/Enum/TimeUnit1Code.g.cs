﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TimeUnit1Code.  ISO2002 ID# _Yl41wdp-Ed-ak6NoX_4Aeg_2073766777.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Unit of time associated with the contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yl41wdp-Ed-ak6NoX_4Aeg_2073766777")]
[Description(@"Unit of time associated with the contract.")]
[DerivedFrom(typeof(TimeUnitCode))]
public enum TimeUnit1Code
{
    /// <summary>
    /// Time unit is calendar day.
    /// Encoded/decoded by serializers as "CalendarDay".
    /// </summary>
    [EnumMember(Value = "DAYC")]
    [IsoId("_Yl41wtp-Ed-ak6NoX_4Aeg_-1921054302")]
    [Description(@"Time unit is calendar day.")]
    CalendarDay,
    
    /// <summary>
    /// Time unit is hour.
    /// Encoded/decoded by serializers as "Hour".
    /// </summary>
    [EnumMember(Value = "HOUR")]
    [IsoId("_Yl41w9p-Ed-ak6NoX_4Aeg_-1921054301")]
    [Description(@"Time unit is hour.")]
    Hour,
    
    /// <summary>
    /// Time unit is minute.
    /// Encoded/decoded by serializers as "Minute".
    /// </summary>
    [EnumMember(Value = "MINU")]
    [IsoId("_Yl41xNp-Ed-ak6NoX_4Aeg_-1921054284")]
    [Description(@"Time unit is minute.")]
    Minute,
    
    /// <summary>
    /// Time unit is month.
    /// Encoded/decoded by serializers as "Month".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_Yl41xdp-Ed-ak6NoX_4Aeg_-1921054283")]
    [Description(@"Time unit is month.")]
    Month,
    
    /// <summary>
    /// Time unit is second.
    /// Encoded/decoded by serializers as "Second".
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_Yl41xtp-Ed-ak6NoX_4Aeg_-1921054275")]
    [Description(@"Time unit is second.")]
    Second,
    
    /// <summary>
    /// Time unit is week.
    /// Encoded/decoded by serializers as "Week".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_Yl41x9p-Ed-ak6NoX_4Aeg_-1921054259")]
    [Description(@"Time unit is week.")]
    Week,
    
    /// <summary>
    /// Time unit is year.
    /// Encoded/decoded by serializers as "Year".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_Yl41yNp-Ed-ak6NoX_4Aeg_-1921054258")]
    [Description(@"Time unit is year.")]
    Year,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TimeUnit1CodeMetadataExtensions
{
    private static readonly TimeUnit1CodeDropdownSource _dropdownSource = new TimeUnit1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITimeUnit1CodeDropdownRow GetMetadata(this TimeUnit1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


