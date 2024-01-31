﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VariationTypeCode.  ISO2002 ID# _aqnvkHynEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of variation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aqnvkHynEeGWJuGCfvwOsQ")]
[Description(@"Specifies the type of variation.")]
[Derivations(typeof(VariationType1Code))]
public enum VariationTypeCode
{
    /// <summary>
    /// Increase to undertaking amount.
    /// Encoded/decoded by serializers as "INCR".
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_t2XLsHynEeGWJuGCfvwOsQ")]
    [Description(@"Increase to undertaking amount.")]
    Increase,
    
    /// <summary>
    /// Decrease to undertaking amount.
    /// Encoded/decoded by serializers as "DECR".
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_0QpukHynEeGWJuGCfvwOsQ")]
    [Description(@"Decrease to undertaking amount.")]
    Decrease,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class VariationTypeCodeMetadataExtensions
{
    private static readonly VariationTypeCodeDropdownSource _dropdownSource = new VariationTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVariationTypeCodeDropdownRow GetMetadata(this VariationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


