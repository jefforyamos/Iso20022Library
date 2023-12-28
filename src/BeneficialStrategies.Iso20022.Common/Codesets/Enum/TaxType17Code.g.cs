﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxType17Code.  ISO2002 ID# _Y3eIUDiGEeaH-93K5JKmzw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y3eIUDiGEeaH-93K5JKmzw")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType17Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Provincial".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rUv78TiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    Provincial,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NationalTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r1U5cTiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    NationalTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StateTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_scwF0TiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    StateTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdingTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tGj30TiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    WithholdingTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CapitalGainTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_u1_OETiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    CapitalGainTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CapitalLossCredit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vCVoATiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    CapitalLossCredit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InterimProfitTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wBkQYTiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    InterimProfitTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StampDuty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wuDi8TiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    StampDuty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WealthTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xH8CkTiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    WealthTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InheritanceTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yWVvYTiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    InheritanceTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SolidaritySurcharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yzNRkTiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    SolidaritySurcharge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxCredit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_z8GzUTiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    TaxCredit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GiftTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0cY14TiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    GiftTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConsumptionTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1CelgTiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    ConsumptionTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EUTaxRetention".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2NwF0TiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    EUTaxRetention,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Aktiengewinn1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3mbI8TiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    Aktiengewinn1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Aktiengewinn2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_31TScTiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    Aktiengewinn2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Zwischengewinn".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4ofC4TiGEeaH-93K5JKmzw")]
    [Description(@"??")]
    Zwischengewinn,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxType17CodeMetadataExtensions
{
    private static readonly TaxType17CodeDropdownSource _dropdownSource = new TaxType17CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxType17CodeDropdownRow GetMetadata(this TaxType17Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


