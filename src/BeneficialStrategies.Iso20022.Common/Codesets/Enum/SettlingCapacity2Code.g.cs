﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlingCapacity2Code.  ISO2002 ID# _4R0NYCW2EeOslcz0TJwprQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the party in the settlement of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4R0NYCW2EeOslcz0TJwprQ")]
[Description(@"Specifies the role of the party in the settlement of the transaction.")]
[DerivedFrom(typeof(SettlingCapacityCode))]
public enum SettlingCapacity2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlingAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7ZoS4SW2EeOslcz0TJwprQ")]
    [Description(@"??")]
    SettlingAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlingCustodian".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9j2HsSW2EeOslcz0TJwprQ")]
    [Description(@"??")]
    SettlingCustodian,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlingPrincipal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9rSMcSW2EeOslcz0TJwprQ")]
    [Description(@"??")]
    SettlingPrincipal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlingRisklessPrincipal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9wCwoSW2EeOslcz0TJwprQ")]
    [Description(@"??")]
    SettlingRisklessPrincipal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlingCapacity2CodeMetadataExtensions
{
    private static readonly SettlingCapacity2CodeDropdownSource _dropdownSource = new SettlingCapacity2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlingCapacity2CodeDropdownRow GetMetadata(this SettlingCapacity2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

