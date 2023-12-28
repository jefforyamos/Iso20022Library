﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Direction1Code.  ISO2002 ID# _awK8Adp-Ed-ak6NoX_4Aeg_1477351773.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the direction of a payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awK8Adp-Ed-ak6NoX_4Aeg_1477351773")]
[Description(@"Specifies the direction of a payment.")]
[DerivedFrom(typeof(DirectionCode))]
public enum Direction1Code
{
    /// <summary>
    /// Down.
    /// Encoded/decoded by serializers as "Down".
    /// </summary>
    [EnumMember(Value = "DRDW")]
    [IsoId("_awK8Atp-Ed-ak6NoX_4Aeg_1520758160")]
    [Description(@"Down.")]
    Down,
    
    /// <summary>
    /// Up.
    /// Encoded/decoded by serializers as "Up".
    /// </summary>
    [EnumMember(Value = "DRUP")]
    [IsoId("_awK8A9p-Ed-ak6NoX_4Aeg_1752561964")]
    [Description(@"Up.")]
    Up,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Direction1CodeMetadataExtensions
{
    private static readonly Direction1CodeDropdownSource _dropdownSource = new Direction1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDirection1CodeDropdownRow GetMetadata(this Direction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


