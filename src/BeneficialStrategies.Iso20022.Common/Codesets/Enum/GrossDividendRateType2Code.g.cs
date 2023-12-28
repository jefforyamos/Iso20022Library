﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GrossDividendRateType2Code.  ISO2002 ID# _Om45wBFZEeKp2ZN13DI_pA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of gross dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Om45wBFZEeKp2ZN13DI_pA")]
[Description(@"Specifies the type of gross dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeCode))]
public enum GrossDividendRateType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CapitalPortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TyKEwRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    CapitalPortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FullPeriodUnitsIncomePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_T5A6sRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    FullPeriodUnitsIncomePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FullyFranked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UAwhcRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    FullyFranked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncomePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UHUccRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    IncomePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Interest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UNumcRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    Interest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LongTermCapitalGain".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UUR6YRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    LongTermCapitalGain,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartWayPeriodUnitsIncomePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UeQ80RFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    PartWayPeriodUnitsIncomePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShortTermCapitalGain".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UlHywRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    ShortTermCapitalGain,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SundryOrOtherIncome".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UngYYRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    SundryOrOtherIncome,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxablePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ut6iYRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    TaxablePortion,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxDeferred".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UwANERFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    TaxDeferred,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxFree".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U2aXERFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    TaxFree,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unfranked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U4WQwRFZEeKp2ZN13DI_pA")]
    [Description(@"??")]
    Unfranked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RealEstatePropertyIncomePortion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_IxzG0RLnEeKJ5uSjVyVvug")]
    [Description(@"??")]
    RealEstatePropertyIncomePortion,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GrossDividendRateType2CodeMetadataExtensions
{
    private static readonly GrossDividendRateType2CodeDropdownSource _dropdownSource = new GrossDividendRateType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGrossDividendRateType2CodeDropdownRow GetMetadata(this GrossDividendRateType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

