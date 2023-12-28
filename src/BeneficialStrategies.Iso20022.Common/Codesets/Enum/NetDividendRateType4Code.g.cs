﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NetDividendRateType4Code.  ISO2002 ID# _nhweG5b7Eee8S7xwGG7Veg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of net dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nhweG5b7Eee8S7xwGG7Veg")]
[Description(@"Specifies the type of net dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeCode))]
public enum NetDividendRateType4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CapitalPortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweHZb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    CapitalPortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FullyFranked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweH5b7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    FullyFranked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncomePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweIJb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    IncomePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Interest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweJZb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    Interest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RealEstatePropertyIncomePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweHpb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    RealEstatePropertyIncomePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SundryOrOtherIncome".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweHJb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    SundryOrOtherIncome,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxablePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweIpb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    TaxablePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxDeferred".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweI5b7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    TaxDeferred,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxFree".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweIZb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    TaxFree,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unfranked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nhweJJb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    Unfranked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConduitForeignIncome".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rkesoZb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    ConduitForeignIncome,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NetDividendRateType4CodeMetadataExtensions
{
    private static readonly NetDividendRateType4CodeDropdownSource _dropdownSource = new NetDividendRateType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INetDividendRateType4CodeDropdownRow GetMetadata(this NetDividendRateType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

