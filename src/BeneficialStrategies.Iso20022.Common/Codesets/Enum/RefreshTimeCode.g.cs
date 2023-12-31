﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RefreshTimeCode.  ISO2002 ID# _Za7nYNp-Ed-ak6NoX_4Aeg_-1515530100.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines when to refresh.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Za7nYNp-Ed-ak6NoX_4Aeg_-1515530100")]
[Description(@"Defines when to refresh.")]
[Derivations(typeof(RefreshTime1Code))]
// External derivations that should be provided by the proper interface are: 
public enum RefreshTimeCode
{
    /// <summary>
    /// After each fill.
    /// Encoded/decoded by serializers as "IMME".
    /// </summary>
    [EnumMember(Value = "IMME")]
    [IsoId("_Za7nYdp-Ed-ak6NoX_4Aeg_-1468432665")]
    [Description(@"After each fill.")]
    Immediate,
    
    /// <summary>
    /// When quantity to be displayed equals 0.
    /// Encoded/decoded by serializers as "EXHA".
    /// </summary>
    [EnumMember(Value = "EXHA")]
    [IsoId("_Za7nYtp-Ed-ak6NoX_4Aeg_-1027912177")]
    [Description(@"When quantity to be displayed equals 0.")]
    Exhaust,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RefreshTimeCodeMetadataExtensions
{
    private static readonly RefreshTimeCodeDropdownSource _dropdownSource = new RefreshTimeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRefreshTimeCodeDropdownRow GetMetadata(this RefreshTimeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


