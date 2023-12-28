﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Operation3Code.  ISO2002 ID# _mec4cNGyEeaokquJJ-K6uA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an AND or an OR operator.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mec4cNGyEeaokquJJ-K6uA")]
[Description(@"Specifies an AND or an OR operator.")]
[DerivedFrom(typeof(OperationV2Code))]
public enum Operation3Code
{
    /// <summary>
    /// Indicates that only when all if all of its elements are valid, the whole expression is valid.
    /// Encoded/decoded by serializers as "And".
    /// </summary>
    [EnumMember(Value = "ANDD")]
    [IsoId("_zxpM0dGyEeaokquJJ-K6uA")]
    [Description(@"Indicates that only when all if all of its elements are valid, the whole expression is valid.")]
    And,
    
    /// <summary>
    /// Indicates that when at least one of its elements is valid, the whole expression is valid.
    /// Encoded/decoded by serializers as "Or".
    /// </summary>
    [EnumMember(Value = "ORRR")]
    [IsoId("_0EAIItGyEeaokquJJ-K6uA")]
    [Description(@"Indicates that when at least one of its elements is valid, the whole expression is valid.")]
    Or,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Operation3CodeMetadataExtensions
{
    private static readonly Operation3CodeDropdownSource _dropdownSource = new Operation3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOperation3CodeDropdownRow GetMetadata(this Operation3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


