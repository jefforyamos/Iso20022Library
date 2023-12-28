﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ShortLongCode.  ISO2002 ID# _ZOtwVdp-Ed-ak6NoX_4Aeg_-300293738.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the securities position is short or long, that is, whether the balance is a negative or positive balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOtwVdp-Ed-ak6NoX_4Aeg_-300293738")]
[Description(@"Specifies whether the securities position is short or long, that is, whether the balance is a negative or positive balance.")]
[Derivations(typeof(ShortLong1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ShortLongCode
{
    /// <summary>
    /// Position is short, that is, the balance is negative.
    /// Encoded/decoded by serializers as "SHOR".
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_ZOtwVtp-Ed-ak6NoX_4Aeg_39564477")]
    [Description(@"Position is short, that is, the balance is negative.")]
    Short,
    
    /// <summary>
    /// Position is long, that is, the balance is positive.
    /// Encoded/decoded by serializers as "LONG".
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_ZOtwV9p-Ed-ak6NoX_4Aeg_92203158")]
    [Description(@"Position is long, that is, the balance is positive.")]
    Long,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ShortLongCodeMetadataExtensions
{
    private static readonly ShortLongCodeDropdownSource _dropdownSource = new ShortLongCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IShortLongCodeDropdownRow GetMetadata(this ShortLongCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


