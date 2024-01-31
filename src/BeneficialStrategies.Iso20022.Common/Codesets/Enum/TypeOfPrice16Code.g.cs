﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice16Code.  ISO2002 ID# _Yx9i4tp-Ed-ak6NoX_4Aeg_-2021057381.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yx9i4tp-Ed-ak6NoX_4Aeg_-2021057381")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice16Code
{
    /// <summary>
    /// Price is the current market price.
    /// Encoded/decoded by serializers as "MRKT".
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_Yx9i49p-Ed-ak6NoX_4Aeg_-1009264882")]
    [Description(@"Price is the current market price.")]
    Market = TypeOfPriceCode.Market, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the estimated indicative price.
    /// Encoded/decoded by serializers as "INDC".
    /// </summary>
    [EnumMember(Value = "INDC")]
    [IsoId("_Yx9i5Np-Ed-ak6NoX_4Aeg_-831146210")]
    [Description(@"Price is the estimated indicative price.")]
    Indicative = TypeOfPriceCode.Indicative, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPrice16CodeMetadataExtensions
{
    private static readonly TypeOfPrice16CodeDropdownSource _dropdownSource = new TypeOfPrice16CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPrice16CodeDropdownRow GetMetadata(this TypeOfPrice16Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


