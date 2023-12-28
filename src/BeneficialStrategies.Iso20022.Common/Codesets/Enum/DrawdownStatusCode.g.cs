﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DrawdownStatusCode.  ISO2002 ID# _t4qL0FKiEeiSDqv62fL07g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a drawdown status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t4qL0FKiEeiSDqv62fL07g")]
[Description(@"Specifies a drawdown status.")]
public enum DrawdownStatusCode
{
    /// <summary>
    /// Pension is not in drawdown.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_0F5KIFKiEeiSDqv62fL07g")]
    [Description(@"Pension is not in drawdown.")]
    None,
    
    /// <summary>
    /// Pension is in partial drawdown.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_3fsXgFKiEeiSDqv62fL07g")]
    [Description(@"Pension is in partial drawdown.")]
    Partial,
    
    /// <summary>
    /// Pension is fully in drawdown.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_5jNucFKiEeiSDqv62fL07g")]
    [Description(@"Pension is fully in drawdown.")]
    Full,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DrawdownStatusCodeMetadataExtensions
{
    private static readonly DrawdownStatusCodeDropdownSource _dropdownSource = new DrawdownStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDrawdownStatusCodeDropdownRow GetMetadata(this DrawdownStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


