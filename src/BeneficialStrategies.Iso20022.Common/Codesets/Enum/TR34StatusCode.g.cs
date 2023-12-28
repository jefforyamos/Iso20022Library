﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TR34StatusCode.  ISO2002 ID# _ke5GkLTiEeeQy4o2AayYHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specific TR34 status that the ATM could use.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ke5GkLTiEeeQy4o2AayYHg")]
[Description(@"Specific TR34 status that the ATM could use.")]
public enum TR34StatusCode
{
    /// <summary>
    /// The device is bound.
    /// Encoded/decoded by serializers as "BUND".
    /// </summary>
    [EnumMember(Value = "BUND")]
    [IsoId("_uee8MLTiEeeQy4o2AayYHg")]
    [Description(@"The device is bound.")]
    Bound,
    
    /// <summary>
    /// The device is unbound.
    /// Encoded/decoded by serializers as "UBND".
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_1_-XsLTiEeeQy4o2AayYHg")]
    [Description(@"The device is unbound.")]
    Unbound,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TR34StatusCodeMetadataExtensions
{
    private static readonly TR34StatusCodeDropdownSource _dropdownSource = new TR34StatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITR34StatusCodeDropdownRow GetMetadata(this TR34StatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

