﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice15Code.  ISO2002 ID# _WOMlo9p-Ed-ak6NoX_4Aeg_1777611092.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOMlo9p-Ed-ak6NoX_4Aeg_1777611092")]
[Description(@"Specifies the type of price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice15Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WOMlpNp-Ed-ak6NoX_4Aeg_1777611101")]
    [Description(@"??")]
    Bid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Offer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WOMlpdp-Ed-ak6NoX_4Aeg_1777611123")]
    [Description(@"??")]
    Offer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NetAssetValue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WOMlptp-Ed-ak6NoX_4Aeg_1777611131")]
    [Description(@"??")]
    NetAssetValue,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPrice15CodeMetadataExtensions
{
    private static readonly TypeOfPrice15CodeDropdownSource _dropdownSource = new TypeOfPrice15CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPrice15CodeDropdownRow GetMetadata(this TypeOfPrice15Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


