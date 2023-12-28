﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VariationType1Code.  ISO2002 ID# __JYLoHynEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of variation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__JYLoHynEeGWJuGCfvwOsQ")]
[Description(@"Specifies the type of variation.")]
[DerivedFrom(typeof(VariationTypeCode))]
public enum VariationType1Code
{
    /// <summary>
    /// Decrease to undertaking amount.
    /// Encoded/decoded by serializers as "Decrease".
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_GXO5dnyoEeGWJuGCfvwOsQ")]
    [Description(@"Decrease to undertaking amount.")]
    Decrease,
    
    /// <summary>
    /// Increase to undertaking amount.
    /// Encoded/decoded by serializers as "Increase".
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_GeibVnyoEeGWJuGCfvwOsQ")]
    [Description(@"Increase to undertaking amount.")]
    Increase,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class VariationType1CodeMetadataExtensions
{
    private static readonly VariationType1CodeDropdownSource _dropdownSource = new VariationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVariationType1CodeDropdownRow GetMetadata(this VariationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


