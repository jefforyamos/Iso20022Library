﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PeriodUnitCode.  ISO2002 ID# _UpPVgRfkEeS1K9gYCN87fQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Unit of time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UpPVgRfkEeS1K9gYCN87fQ")]
[Description(@"Unit of time.")]
public enum PeriodUnitCode
{
    /// <summary>
    /// Counted in days.
    /// Encoded/decoded by serializers as "DAYS".
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_XFiY0BfkEeS1K9gYCN87fQ")]
    [Description(@"Counted in days.")]
    Days,
    
    /// <summary>
    /// Counted in weeks.
    /// Encoded/decoded by serializers as "WEEK".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_YU35wBfkEeS1K9gYCN87fQ")]
    [Description(@"Counted in weeks.")]
    Weeks,
    
    /// <summary>
    /// Counted in months.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ZaYwUBfkEeS1K9gYCN87fQ")]
    [Description(@"Counted in months.")]
    Months,
    
    /// <summary>
    /// Counted in some other unit.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_b9rzgBfkEeS1K9gYCN87fQ")]
    [Description(@"Counted in some other unit.")]
    Other,
    
    /// <summary>
    /// Counted in years.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_c6HmkBfkEeS1K9gYCN87fQ")]
    [Description(@"Counted in years.")]
    Years,
    
    /// <summary>
    /// Extra Days
    /// Encoded/decoded by serializers as "EXDY".
    /// </summary>
    [EnumMember(Value = "EXDY")]
    [IsoId("__zIsB3yKEemHsOqJOzMVfg")]
    [Description(@"Extra Days")]
    ExtraDays,
    
    /// <summary>
    /// Half days
    /// Encoded/decoded by serializers as "HFDA".
    /// </summary>
    [EnumMember(Value = "HFDA")]
    [IsoId("__zIsCHyKEemHsOqJOzMVfg")]
    [Description(@"Half days")]
    HalfDays,
    
    /// <summary>
    /// Period unit expressed in hours.
    /// Encoded/decoded by serializers as "HOUR".
    /// </summary>
    [EnumMember(Value = "HOUR")]
    [IsoId("__zIsCXyKEemHsOqJOzMVfg")]
    [Description(@"Period unit expressed in hours.")]
    Hours,
    
    /// <summary>
    /// Period unit expressed in minutes
    /// Encoded/decoded by serializers as "MINU".
    /// </summary>
    [EnumMember(Value = "MINU")]
    [IsoId("__zIsCnyKEemHsOqJOzMVfg")]
    [Description(@"Period unit expressed in minutes")]
    Minutes,
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("__zIsC3yKEemHsOqJOzMVfg")]
    [Description(@"Other National")]
    OtherNational,
    
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("__zIsDHyKEemHsOqJOzMVfg")]
    [Description(@"Other Private")]
    OtherPrivate,
    
    /// <summary>
    /// Period unit expressed in seconds.
    /// Encoded/decoded by serializers as "SECO".
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("__zIsDXyKEemHsOqJOzMVfg")]
    [Description(@"Period unit expressed in seconds.")]
    Seconds,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PeriodUnitCodeMetadataExtensions
{
    private static readonly PeriodUnitCodeDropdownSource _dropdownSource = new PeriodUnitCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPeriodUnitCodeDropdownRow GetMetadata(this PeriodUnitCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

