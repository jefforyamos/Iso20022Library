﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OperationV2Code.  ISO2002 ID# _cS11gNGxEeaokquJJ-K6uA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the relationship between two variables.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cS11gNGxEeaokquJJ-K6uA")]
[Description(@"Indicates the relationship between two variables.")]
public enum OperationV2Code
{
    /// <summary>
    /// Indicates that only when all if all of its elements are valid, the whole expression is valid.
    /// Encoded/decoded by serializers as "ANDD".
    /// </summary>
    [EnumMember(Value = "ANDD")]
    [IsoId("_gq4MwNGxEeaokquJJ-K6uA")]
    [Description(@"Indicates that only when all if all of its elements are valid, the whole expression is valid.")]
    And,
    
    /// <summary>
    /// Indicates that when at least one of its elements is valid, the whole expression is valid.
    /// Encoded/decoded by serializers as "ORRR".
    /// </summary>
    [EnumMember(Value = "ORRR")]
    [IsoId("_hCk7ENGxEeaokquJJ-K6uA")]
    [Description(@"Indicates that when at least one of its elements is valid, the whole expression is valid.")]
    Or,
    
    /// <summary>
    /// Indicates that only when both elements differ (one is valid, one is invalid), the whole expression is valid.
    /// Encoded/decoded by serializers as "XORR".
    /// </summary>
    [EnumMember(Value = "XORR")]
    [IsoId("_hI1UENGxEeaokquJJ-K6uA")]
    [Description(@"Indicates that only when both elements differ (one is valid, one is invalid), the whole expression is valid.")]
    ExclusiveOr,
    
    /// <summary>
    /// Indicates a range delimited by two variables.
    /// Encoded/decoded by serializers as "TILL".
    /// </summary>
    [EnumMember(Value = "TILL")]
    [IsoId("_hWZO8NGxEeaokquJJ-K6uA")]
    [Description(@"Indicates a range delimited by two variables.")]
    Till,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OperationV2CodeMetadataExtensions
{
    private static readonly OperationV2CodeDropdownSource _dropdownSource = new OperationV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOperationV2CodeDropdownRow GetMetadata(this OperationV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


