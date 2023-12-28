﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice2Code.  ISO2002 ID# _VeNTK9p-Ed-ak6NoX_4Aeg_-1127432274.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VeNTK9p-Ed-ak6NoX_4Aeg_-1127432274")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeNTLNp-Ed-ak6NoX_4Aeg_-513561926")]
    [Description(@"??")]
    Bid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Offer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeNTLdp-Ed-ak6NoX_4Aeg_-513561594")]
    [Description(@"??")]
    Offer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NetAssetValue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeNTLtp-Ed-ak6NoX_4Aeg_-512641470")]
    [Description(@"??")]
    NetAssetValue,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Creation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeNTL9p-Ed-ak6NoX_4Aeg_-512641316")]
    [Description(@"??")]
    Creation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancellation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeNTMNp-Ed-ak6NoX_4Aeg_-512640430")]
    [Description(@"??")]
    Cancellation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeXEINp-Ed-ak6NoX_4Aeg_-512640060")]
    [Description(@"??")]
    Interim,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Swing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeXEIdp-Ed-ak6NoX_4Aeg_1768616933")]
    [Description(@"??")]
    Swing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeXEItp-Ed-ak6NoX_4Aeg_1779700255")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Mid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeXEI9p-Ed-ak6NoX_4Aeg_1791704927")]
    [Description(@"??")]
    Mid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reinvestment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeXEJNp-Ed-ak6NoX_4Aeg_1837879961")]
    [Description(@"??")]
    Reinvestment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Switch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VeXEJdp-Ed-ak6NoX_4Aeg_1851734770")]
    [Description(@"??")]
    Switch,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPrice2CodeMetadataExtensions
{
    private static readonly TypeOfPrice2CodeDropdownSource _dropdownSource = new TypeOfPrice2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPrice2CodeDropdownRow GetMetadata(this TypeOfPrice2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


