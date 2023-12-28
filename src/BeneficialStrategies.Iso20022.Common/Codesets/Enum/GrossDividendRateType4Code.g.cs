﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GrossDividendRateType4Code.  ISO2002 ID# _ghpRXZb7Eee8S7xwGG7Veg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ghpRXZb7Eee8S7xwGG7Veg")]
[Description(@"Specifies the type of dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeCode))]
public enum GrossDividendRateType4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CapitalPortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRZpb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    CapitalPortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FullyFranked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRZZb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    FullyFranked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncomePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRZ5b7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    IncomePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Interest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRX5b7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    Interest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LongTermCapitalGain".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRXpb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    LongTermCapitalGain,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RealEstatePropertyIncomePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRYZb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    RealEstatePropertyIncomePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShortTermCapitalGain".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRY5b7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    ShortTermCapitalGain,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SundryOrOtherIncome".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRaZb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    SundryOrOtherIncome,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxablePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRZJb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    TaxablePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxDeferred".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRYJb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    TaxDeferred,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxFree".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRaJb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    TaxFree,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unfranked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ghpRYpb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    Unfranked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConduitForeignIncome".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_luUKgZb7Eee8S7xwGG7Veg")]
    [Description(@"??")]
    ConduitForeignIncome,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GrossDividendRateType4CodeMetadataExtensions
{
    private static readonly GrossDividendRateType4CodeDropdownSource _dropdownSource = new GrossDividendRateType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGrossDividendRateType4CodeDropdownRow GetMetadata(this GrossDividendRateType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


