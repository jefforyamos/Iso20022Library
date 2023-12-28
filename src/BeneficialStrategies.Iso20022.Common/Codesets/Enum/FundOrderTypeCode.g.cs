﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundOrderTypeCode.  ISO2002 ID# _atVqdtp-Ed-ak6NoX_4Aeg_267040757.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atVqdtp-Ed-ak6NoX_4Aeg_267040757")]
[Description(@"Specifies the category of the investment fund order.")]
[Derivations(typeof(FundOrderType2Code),typeof(FundOrderType6Code),typeof(FundOrderType3Code),typeof(FundOrderType5Code),typeof(FundOrderType4Code),typeof(HedgeFundOrderType2Code),typeof(HedgeFundOrderType1Code),typeof(FundOrderType1Code),typeof(FundOrderType7Code),typeof(FundOrderType8Code),typeof(FundOrderType10Code))]
// External derivations that should be provided by the proper interface are: 
public enum FundOrderTypeCode
{
    /// <summary>
    /// Investment fund order is part of a bed and breakfast transaction.
    /// Encoded/decoded by serializers as "BEDB".
    /// </summary>
    [EnumMember(Value = "BEDB")]
    [IsoId("_atVqd9p-Ed-ak6NoX_4Aeg_1897052175")]
    [Description(@"Investment fund order is part of a bed and breakfast transaction.")]
    BedAndBreakfast,
    
    /// <summary>
    /// Investment fund order is related to an investment plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as "INVP".
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_atfbcNp-Ed-ak6NoX_4Aeg_1897052427")]
    [Description(@"Investment fund order is related to an investment plan (only applicable to a subscription).")]
    InvestmentPlan,
    
    /// <summary>
    /// Investment fund order is executed with specific pre-advice conditions.
    /// Encoded/decoded by serializers as "PREA".
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_atfbcdp-Ed-ak6NoX_4Aeg_1897052487")]
    [Description(@"Investment fund order is executed with specific pre-advice conditions.")]
    PreAdvice,
    
    /// <summary>
    /// Investment fund order is a staff order.
    /// Encoded/decoded by serializers as "STAF".
    /// </summary>
    [EnumMember(Value = "STAF")]
    [IsoId("_atfbctp-Ed-ak6NoX_4Aeg_1940457443")]
    [Description(@"Investment fund order is a staff order.")]
    StaffOrder,
    
    /// <summary>
    /// Investment fund order is a regular savings plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as "RGSV".
    /// </summary>
    [EnumMember(Value = "RGSV")]
    [IsoId("_atfbc9p-Ed-ak6NoX_4Aeg_1886312212")]
    [Description(@"Investment fund order is a regular savings plan (only applicable to a subscription).")]
    RegularSavingsPlan,
    
    /// <summary>
    /// Another type of investment fund order.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_atfbdNp-Ed-ak6NoX_4Aeg_1886312264")]
    [Description(@"Another type of investment fund order.")]
    Other,
    
    /// <summary>
    /// Investment fund order is paying extra money into to an existing plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as "RGSU".
    /// </summary>
    [EnumMember(Value = "RGSU")]
    [IsoId("_atfbddp-Ed-ak6NoX_4Aeg_-518098615")]
    [Description(@"Investment fund order is paying extra money into to an existing plan (only applicable to a subscription).")]
    RegularSavingsPlanUpdate,
    
    /// <summary>
    /// Investment fund order is a dividend reinvestment (only applicable to a subscription).
    /// Encoded/decoded by serializers as "RDIV".
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_atfbdtp-Ed-ak6NoX_4Aeg_-517178582")]
    [Description(@"Investment fund order is a dividend reinvestment (only applicable to a subscription).")]
    ReinvestmentOfDividend,
    
    /// <summary>
    /// That part of an investment fund order attributed to a normal staff portion.
    /// Encoded/decoded by serializers as "NSPN".
    /// </summary>
    [EnumMember(Value = "NSPN")]
    [IsoId("_atfbd9p-Ed-ak6NoX_4Aeg_-494089538")]
    [Description(@"That part of an investment fund order attributed to a normal staff portion.")]
    NormalStaffPortion,
    
    /// <summary>
    /// That part of an investment fund order attributed to a normal client portion.
    /// Encoded/decoded by serializers as "NCPN".
    /// </summary>
    [EnumMember(Value = "NCPN")]
    [IsoId("_atfbeNp-Ed-ak6NoX_4Aeg_-494089503")]
    [Description(@"That part of an investment fund order attributed to a normal client portion.")]
    NormalClientPortion,
    
    /// <summary>
    /// That part of an investment fund order attributed to a staff member with a savings plan.
    /// Encoded/decoded by serializers as "SWSP".
    /// </summary>
    [EnumMember(Value = "SWSP")]
    [IsoId("_atfbedp-Ed-ak6NoX_4Aeg_-494089382")]
    [Description(@"That part of an investment fund order attributed to a staff member with a savings plan.")]
    StaffWithSavingsPlan,
    
    /// <summary>
    /// That part of an investment fund order attributed to a client with a savings plan.
    /// Encoded/decoded by serializers as "CWSP".
    /// </summary>
    [EnumMember(Value = "CWSP")]
    [IsoId("_atolYNp-Ed-ak6NoX_4Aeg_-494089347")]
    [Description(@"That part of an investment fund order attributed to a client with a savings plan.")]
    ClientWithSavingsPlan,
    
    /// <summary>
    /// Investment fund order is for a limited partnership instrument.
    /// Encoded/decoded by serializers as "NUNI".
    /// </summary>
    [EnumMember(Value = "NUNI")]
    [IsoId("_atolYdp-Ed-ak6NoX_4Aeg_802267736")]
    [Description(@"Investment fund order is for a limited partnership instrument.")]
    NonUnitized,
    
    /// <summary>
    /// Investment fund order contains a side pocket component.
    /// Encoded/decoded by serializers as "SPCM".
    /// </summary>
    [EnumMember(Value = "SPCM")]
    [IsoId("_atolYtp-Ed-ak6NoX_4Aeg_802267839")]
    [Description(@"Investment fund order contains a side pocket component.")]
    SidePocketComponent,
    
    /// <summary>
    /// Investment fund order is a side pocket order.
    /// Encoded/decoded by serializers as "SPOR".
    /// </summary>
    [EnumMember(Value = "SPOR")]
    [IsoId("_atolY9p-Ed-ak6NoX_4Aeg_802268168")]
    [Description(@"Investment fund order is a side pocket order.")]
    SidePocketOrder,
    
    /// <summary>
    /// Investment fund order is for a unitized instrument.
    /// Encoded/decoded by serializers as "UNIT".
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_atolZNp-Ed-ak6NoX_4Aeg_802268529")]
    [Description(@"Investment fund order is for a unitized instrument.")]
    Unitized,
    
    /// <summary>
    /// Investment fund order is a subscription.
    /// Encoded/decoded by serializers as "SUBS".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_atolZdp-Ed-ak6NoX_4Aeg_802268649")]
    [Description(@"Investment fund order is a subscription.")]
    Subscription,
    
    /// <summary>
    /// Investment fund order is a redemption.
    /// Encoded/decoded by serializers as "REDM".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_atyWYNp-Ed-ak6NoX_4Aeg_802268786")]
    [Description(@"Investment fund order is a redemption.")]
    Redemption,
    
    /// <summary>
    /// Investment fund order is a switch.
    /// Encoded/decoded by serializers as "SWIT".
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_atyWYdp-Ed-ak6NoX_4Aeg_802269141")]
    [Description(@"Investment fund order is a switch.")]
    Switch,
    
    /// <summary>
    /// Investment fund order specifies a top up.
    /// Encoded/decoded by serializers as "TOPU".
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_atyWYtp-Ed-ak6NoX_4Aeg_802269519")]
    [Description(@"Investment fund order specifies a top up.")]
    TopUp,
    
    /// <summary>
    /// Investment fund order specifies a hold back.
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_atyWY9p-Ed-ak6NoX_4Aeg_802269656")]
    [Description(@"Investment fund order specifies a hold back.")]
    HoldBack,
    
    /// <summary>
    /// All type of orders.
    /// Encoded/decoded by serializers as "ALLL".
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_Ab3EoBOtEeKd9pI2QZcqvg_-1821151523")]
    [Description(@"All type of orders.")]
    All,
    
    /// <summary>
    /// Switch out or switch from.
    /// Encoded/decoded by serializers as "SWII".
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_Acc6gBOtEeKd9pI2QZcqvg_1473147179")]
    [Description(@"Switch out or switch from.")]
    SwitchFrom,
    
    /// <summary>
    /// Switch in or switch to.
    /// Encoded/decoded by serializers as "SWIO".
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_Acc6gROtEeKd9pI2QZcqvg_-1867895001")]
    [Description(@"Switch in or switch to.")]
    SwitchTo,
    
    /// <summary>
    /// Transfer in.
    /// Encoded/decoded by serializers as "TRAI".
    /// </summary>
    [EnumMember(Value = "TRAI")]
    [IsoId("_AcmrgBOtEeKd9pI2QZcqvg_1734255276")]
    [Description(@"Transfer in.")]
    TransferIn,
    
    /// <summary>
    /// Transfer out.
    /// Encoded/decoded by serializers as "TRAO".
    /// </summary>
    [EnumMember(Value = "TRAO")]
    [IsoId("_AcmrgROtEeKd9pI2QZcqvg_-1071874864")]
    [Description(@"Transfer out.")]
    TransferOut,
    
    /// <summary>
    /// Purchase of securities.
    /// Encoded/decoded by serializers as "BUYI".
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_C_2DQFxUEeWfo_WUOMFqVQ")]
    [Description(@"Purchase of securities.")]
    SecuritiesPurchase,
    
    /// <summary>
    /// Sale of securities.
    /// Encoded/decoded by serializers as "SELL".
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_IQbzIFxUEeWfo_WUOMFqVQ")]
    [Description(@"Sale of securities.")]
    SecuritiesSale,
    
    /// <summary>
    /// Investment fund order is for a withdrawal investment plan (only applicable to a redemption).
    /// Encoded/decoded by serializers as "WIDP".
    /// </summary>
    [EnumMember(Value = "WIDP")]
    [IsoId("_qaT3gEctEeaWfr8CWb3Bqg")]
    [Description(@"Investment fund order is for a withdrawal investment plan (only applicable to a redemption).")]
    Withdrawal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundOrderTypeCodeMetadataExtensions
{
    private static readonly FundOrderTypeCodeDropdownSource _dropdownSource = new FundOrderTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundOrderTypeCodeDropdownRow GetMetadata(this FundOrderTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


