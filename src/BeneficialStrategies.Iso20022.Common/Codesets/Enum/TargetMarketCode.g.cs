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
    /// </summary>
    [EnumMember(Value = "NSCO")]
    [IsoId("_wXbtwNdcEeibyvRfU9vJ7w")]
    [Description(@"No, is not applicable.")]
    NSCO,
    
    /// <summary>
    /// Yes, is applicable.
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("_1WaJMNdcEeibyvRfU9vJ7w")]
    [Description(@"Yes, is applicable.")]
    YSCO,
    
    /// <summary>
    /// Neutral or has no impact.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_4Qq64NdcEeibyvRfU9vJ7w")]
    [Description(@"Neutral or has no impact.")]
    NEUT,
    
    /// <summary>
    /// Not known whether applicable.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_-6d5YNdcEeibyvRfU9vJ7w")]
    [Description(@"Not known whether applicable.")]
    UKWN,
    
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


