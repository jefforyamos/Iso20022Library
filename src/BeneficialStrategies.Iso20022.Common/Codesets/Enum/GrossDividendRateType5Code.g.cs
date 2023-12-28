﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GrossDividendRateType5Code.  ISO2002 ID# __sZAr5b8Eee8S7xwGG7Veg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of gross dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__sZAr5b8Eee8S7xwGG7Veg")]
[Description(@"Specifies the type of gross dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeCode))]
public enum GrossDividendRateType5Code
{
    /// <summary>
    /// Rate relating to the underlying security for which capital is distributed.
    /// Encoded/decoded by serializers as "CapitalPortion".
    /// </summary>
    [EnumMember(Value = "CAPO")]
    [IsoId("__sZAuZb8Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which capital is distributed.")]
    CapitalPortion,
    
    /// <summary>
    /// Distribution rate relating to the full period units, for example Group I units in UK.
    /// Encoded/decoded by serializers as "FullPeriodUnitsIncomePortion".
    /// </summary>
    [EnumMember(Value = "FUPU")]
    [IsoId("__sZAtJb8Eee8S7xwGG7Veg")]
    [Description(@"Distribution rate relating to the full period units, for example Group I units in UK.")]
    FullPeriodUnitsIncomePortion,
    
    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// Encoded/decoded by serializers as "FullyFranked".
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("__sZAsZb8Eee8S7xwGG7Veg")]
    [Description(@"Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.")]
    FullyFranked,
    
    /// <summary>
    /// Rate relating to the underlying security for which income is distributed.
    /// Encoded/decoded by serializers as "IncomePortion".
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("__sZAtZb8Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which income is distributed.")]
    IncomePortion,
    
    /// <summary>
    /// Rate relating to the underlying security for which interest is paid.
    /// Encoded/decoded by serializers as "Interest".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("__sZAs5b8Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which interest is paid.")]
    Interest,
    
    /// <summary>
    /// Long term capital gain.
    /// Encoded/decoded by serializers as "LongTermCapitalGain".
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("__sZAuJb8Eee8S7xwGG7Veg")]
    [Description(@"Long term capital gain.")]
    LongTermCapitalGain,
    
    /// <summary>
    /// Distribution rate relating to the part way period units, for example Group II units in UK.
    /// Encoded/decoded by serializers as "PartWayPeriodUnitsIncomePortion".
    /// </summary>
    [EnumMember(Value = "PAPU")]
    [IsoId("__sZAt5b8Eee8S7xwGG7Veg")]
    [Description(@"Distribution rate relating to the part way period units, for example Group II units in UK.")]
    PartWayPeriodUnitsIncomePortion,
    
    /// <summary>
    /// Short term capital gain.
    /// Encoded/decoded by serializers as "ShortTermCapitalGain".
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("__sZAupb8Eee8S7xwGG7Veg")]
    [Description(@"Short term capital gain.")]
    ShortTermCapitalGain,
    
    /// <summary>
    /// Rate relating to the underlying security for which other income is paid.
    /// Encoded/decoded by serializers as "SundryOrOtherIncome".
    /// </summary>
    [EnumMember(Value = "SOIC")]
    [IsoId("__sZAvJb8Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which other income is paid.")]
    SundryOrOtherIncome,
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is charged.
    /// Encoded/decoded by serializers as "TaxablePortion".
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("__sZAtpb8Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which tax is charged.")]
    TaxablePortion,
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as "TaxDeferred".
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("__sZAspb8Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred,
    
    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as "TaxFree".
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("__sZAvZb8Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFree,
    
    /// <summary>
    /// Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.
    /// Encoded/decoded by serializers as "Unfranked".
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("__sZAsJb8Eee8S7xwGG7Veg")]
    [Description(@"Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.")]
    Unfranked,
    
    /// <summary>
    /// Rate of income distribution originated by real estate investment.
    /// Encoded/decoded by serializers as "RealEstatePropertyIncomePortion".
    /// </summary>
    [EnumMember(Value = "REES")]
    [IsoId("__sZAu5b8Eee8S7xwGG7Veg")]
    [Description(@"Rate of income distribution originated by real estate investment.")]
    RealEstatePropertyIncomePortion,
    
    /// <summary>
    /// Rate relating to a conduit foreign income type.
    /// Encoded/decoded by serializers as "ConduitForeignIncome".
    /// </summary>
    [EnumMember(Value = "CDFI")]
    [IsoId("_EtAa0Zb9Eee8S7xwGG7Veg")]
    [Description(@"Rate relating to a conduit foreign income type.")]
    ConduitForeignIncome,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GrossDividendRateType5CodeMetadataExtensions
{
    private static readonly GrossDividendRateType5CodeDropdownSource _dropdownSource = new GrossDividendRateType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGrossDividendRateType5CodeDropdownRow GetMetadata(this GrossDividendRateType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


