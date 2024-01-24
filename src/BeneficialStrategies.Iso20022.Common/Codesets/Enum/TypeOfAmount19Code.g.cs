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
    /// Telephone connection-related charge
    /// Encoded/decoded by serializers as "CONN".
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_d9j_0X0mEemfrNOe0zHQyg")]
    [Description(@"Telephone connection-related charge")]
    Connect = TypeOfAmountCode.Connect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insurance charges 
    /// Encoded/decoded by serializers as "INSU".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_d9j_030mEemfrNOe0zHQyg")]
    [Description(@"Insurance charges ")]
    Insurance = TypeOfAmountCode.Insurance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges related to a long distance call. 
    /// Encoded/decoded by serializers as "LNDS".
    /// </summary>
    [EnumMember(Value = "LNDS")]
    [IsoId("_d9j_1X0mEemfrNOe0zHQyg")]
    [Description(@"Charges related to a long distance call. ")]
    LongDistance = TypeOfAmountCode.LongDistance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Miscellaneous charges not elsewhere defined
    /// Encoded/decoded by serializers as "MISC".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_d9j_130mEemfrNOe0zHQyg")]
    [Description(@"Miscellaneous charges not elsewhere defined")]
    Miscellaneous = TypeOfAmountCode.Miscellaneous, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_d9j_2X0mEemfrNOe0zHQyg")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational = TypeOfAmountCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_d9j_230mEemfrNOe0zHQyg")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate = TypeOfAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Telephone usage-related charge
    /// Encoded/decoded by serializers as "USGE".
    /// </summary>
    [EnumMember(Value = "USGE")]
    [IsoId("_d9j_3X0mEemfrNOe0zHQyg")]
    [Description(@"Telephone usage-related charge")]
    Usage = TypeOfAmountCode.Usage, // same ordinal as derivation source for type conversions
    
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


