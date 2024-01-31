﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundOrderType8Code.  ISO2002 ID# _y8_NwEcuEeam48hW0M8V2Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_y8_NwEcuEeam48hW0M8V2Q")]
[Description(@"Specifies the category of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType8Code
{
    /// <summary>
    /// Investment fund order is part of a bed and breakfast transaction.
    /// Encoded/decoded by serializers as "BEDB".
    /// </summary>
    [EnumMember(Value = "BEDB")]
    [IsoId("_3gJ28UcuEeam48hW0M8V2Q")]
    [Description(@"Investment fund order is part of a bed and breakfast transaction.")]
    BedAndBreakfast = FundOrderTypeCode.BedAndBreakfast, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is related to an investment plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as "INVP".
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_4NYJUUcuEeam48hW0M8V2Q")]
    [Description(@"Investment fund order is related to an investment plan (only applicable to a subscription).")]
    InvestmentPlan = FundOrderTypeCode.InvestmentPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is executed with specific pre-advice conditions.
    /// Encoded/decoded by serializers as "PREA".
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_4wpOcUcuEeam48hW0M8V2Q")]
    [Description(@"Investment fund order is executed with specific pre-advice conditions.")]
    PreAdvice = FundOrderTypeCode.PreAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a regular savings plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as "RGSV".
    /// </summary>
    [EnumMember(Value = "RGSV")]
    [IsoId("_5Pu-MUcuEeam48hW0M8V2Q")]
    [Description(@"Investment fund order is a regular savings plan (only applicable to a subscription).")]
    RegularSavingsPlan = FundOrderTypeCode.RegularSavingsPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is paying extra money into to an existing plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as "RGSU".
    /// </summary>
    [EnumMember(Value = "RGSU")]
    [IsoId("_5c-I8UcuEeam48hW0M8V2Q")]
    [Description(@"Investment fund order is paying extra money into to an existing plan (only applicable to a subscription).")]
    RegularSavingsPlanUpdate = FundOrderTypeCode.RegularSavingsPlanUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a dividend reinvestment (only applicable to a subscription).
    /// Encoded/decoded by serializers as "RDIV".
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_6Bkq0UcuEeam48hW0M8V2Q")]
    [Description(@"Investment fund order is a dividend reinvestment (only applicable to a subscription).")]
    ReinvestmentOfDividend = FundOrderTypeCode.ReinvestmentOfDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a staff order.
    /// Encoded/decoded by serializers as "STAF".
    /// </summary>
    [EnumMember(Value = "STAF")]
    [IsoId("_6fxpwUcuEeam48hW0M8V2Q")]
    [Description(@"Investment fund order is a staff order.")]
    StaffOrder = FundOrderTypeCode.StaffOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is for a withdrawal investment plan (only applicable to a redemption).
    /// Encoded/decoded by serializers as "WIDP".
    /// </summary>
    [EnumMember(Value = "WIDP")]
    [IsoId("_7D7fsUcuEeam48hW0M8V2Q")]
    [Description(@"Investment fund order is for a withdrawal investment plan (only applicable to a redemption).")]
    Withdrawal = FundOrderTypeCode.Withdrawal, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundOrderType8CodeMetadataExtensions
{
    private static readonly FundOrderType8CodeDropdownSource _dropdownSource = new FundOrderType8CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundOrderType8CodeDropdownRow GetMetadata(this FundOrderType8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


