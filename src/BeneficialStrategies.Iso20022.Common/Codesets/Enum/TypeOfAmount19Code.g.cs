﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfAmount19Code.  ISO2002 ID# _or7VMPfKEei89sMSHxl1ew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification or qualification of the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_or7VMPfKEei89sMSHxl1ew")]
[Description(@"Identification or qualification of the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount19Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Connect".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d9j_0X0mEemfrNOe0zHQyg")]
    [Description(@"??")]
    Connect,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Insurance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d9j_030mEemfrNOe0zHQyg")]
    [Description(@"??")]
    Insurance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LongDistance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d9j_1X0mEemfrNOe0zHQyg")]
    [Description(@"??")]
    LongDistance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Miscellaneous".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d9j_130mEemfrNOe0zHQyg")]
    [Description(@"??")]
    Miscellaneous,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d9j_2X0mEemfrNOe0zHQyg")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d9j_230mEemfrNOe0zHQyg")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Usage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d9j_3X0mEemfrNOe0zHQyg")]
    [Description(@"??")]
    Usage,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfAmount19CodeMetadataExtensions
{
    private static readonly TypeOfAmount19CodeDropdownSource _dropdownSource = new TypeOfAmount19CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfAmount19CodeDropdownRow GetMetadata(this TypeOfAmount19Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

