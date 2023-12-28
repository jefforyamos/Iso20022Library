﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TargetMarketCode.  ISO2002 ID# _hXsYANdcEeibyvRfU9vJ7w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a financial product is in scope of a target market parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hXsYANdcEeibyvRfU9vJ7w")]
[Description(@"Specifies whether a financial product is in scope of a target market parameter.")]
public enum TargetMarketCode
{
    /// <summary>
    /// No, is not applicable.
    /// Encoded/decoded by serializers as "NSCO".
    /// </summary>
    [EnumMember(Value = "NSCO")]
    [IsoId("_wXbtwNdcEeibyvRfU9vJ7w")]
    [Description(@"No, is not applicable.")]
    NotInScope,
    
    /// <summary>
    /// Yes, is applicable.
    /// Encoded/decoded by serializers as "YSCO".
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("_1WaJMNdcEeibyvRfU9vJ7w")]
    [Description(@"Yes, is applicable.")]
    InScope,
    
    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as "NEUT".
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_4Qq64NdcEeibyvRfU9vJ7w")]
    [Description(@"Neutral or has no impact.")]
    Neutral,
    
    /// <summary>
    /// Not known whether applicable.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_-6d5YNdcEeibyvRfU9vJ7w")]
    [Description(@"Not known whether applicable.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TargetMarketCodeMetadataExtensions
{
    private static readonly TargetMarketCodeDropdownSource _dropdownSource = new TargetMarketCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITargetMarketCodeDropdownRow GetMetadata(this TargetMarketCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


