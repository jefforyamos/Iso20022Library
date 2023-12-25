﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundTransactionTypeCode.  ISO2002 ID# _aczUGNp-Ed-ak6NoX_4Aeg_-1474043592.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aczUGNp-Ed-ak6NoX_4Aeg_-1474043592")]
[Description(@"Specifies the type of transaction.")]
public enum InvestmentFundTransactionTypeCode
{
    /// <summary>
    /// Transaction is a redemption of an investment fund.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ac8eANp-Ed-ak6NoX_4Aeg_-1414014899")]
    [Description(@"Transaction is a redemption of an investment fund.")]
    REDM,
    
    /// <summary>
    /// Transaction is a subscription to an investment fund.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ac8eAdp-Ed-ak6NoX_4Aeg_-1414014882")]
    [Description(@"Transaction is a subscription to an investment fund.")]
    SUBS,
    
    /// <summary>
    /// Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement.
    /// </summary>
    [EnumMember(Value = "SSPL")]
    [IsoId("_ac8eAtp-Ed-ak6NoX_4Aeg_-1414014864")]
    [Description(@"Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement.")]
    SSPL,
    
    /// <summary>
    /// Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past.
    /// </summary>
    [EnumMember(Value = "RWPL")]
    [IsoId("_ac8eA9p-Ed-ak6NoX_4Aeg_-1414014829")]
    [Description(@"Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past.")]
    RWPL,
    
    /// <summary>
    /// Transaction is a change between investment funds (usually of the same family) with or without cash in/out, at more interesting conditions than a separate redemption or a separate subscription.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_ac8eBNp-Ed-ak6NoX_4Aeg_-1414014804")]
    [Description(@"Transaction is a change between investment funds (usually of the same family) with or without cash in/out, at more interesting conditions than a separate redemption or a separate subscription.")]
    SWIC,
    
    /// <summary>
    /// Transaction is the result of a corporate action.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ac8eBdp-Ed-ak6NoX_4Aeg_-1414014787")]
    [Description(@"Transaction is the result of a corporate action.")]
    CAEV,
    
    /// <summary>
    /// Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management.
    /// </summary>
    [EnumMember(Value = "TRIN")]
    [IsoId("_ac8eBtp-Ed-ak6NoX_4Aeg_-1414014744")]
    [Description(@"Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management.")]
    TRIN,
    
    /// <summary>
    /// Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management.
    /// </summary>
    [EnumMember(Value = "TOUT")]
    [IsoId("_ac8eB9p-Ed-ak6NoX_4Aeg_-1414014726")]
    [Description(@"Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management.")]
    TOUT,
    
    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_ac8eCNp-Ed-ak6NoX_4Aeg_-1414014708")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SWII,
    
    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_ac8eCdp-Ed-ak6NoX_4Aeg_-1414014673")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SWIO,
    
    /// <summary>
    /// Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure.
    /// </summary>
    [EnumMember(Value = "SUAA")]
    [IsoId("_adGPANp-Ed-ak6NoX_4Aeg_-1414014431")]
    [Description(@"Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure.")]
    SUAA,
    
    /// <summary>
    /// Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure.
    /// </summary>
    [EnumMember(Value = "REAA")]
    [IsoId("_adGPAdp-Ed-ak6NoX_4Aeg_-1414014396")]
    [Description(@"Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure.")]
    REAA,
    
    /// <summary>
    /// Transaction is a cross-in.
    /// </summary>
    [EnumMember(Value = "CROI")]
    [IsoId("_adGPAtp-Ed-ak6NoX_4Aeg_1958826424")]
    [Description(@"Transaction is a cross-in.")]
    CROI,
    
    /// <summary>
    /// Transaction is a cross out.
    /// </summary>
    [EnumMember(Value = "CROO")]
    [IsoId("_adGPA9p-Ed-ak6NoX_4Aeg_-679609394")]
    [Description(@"Transaction is a cross out.")]
    CROO,
    
    /// <summary>
    /// Transaction is an InSpecie.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_adGPBNp-Ed-ak6NoX_4Aeg_1557156653")]
    [Description(@"Transaction is an InSpecie.")]
    INSP,
    
    /// <summary>
    /// Transaction is a dividend.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_adGPBdp-Ed-ak6NoX_4Aeg_2067863197")]
    [Description(@"Transaction is a dividend.")]
    DIVI,
    
    /// <summary>
    /// Transaction is another type of transaction.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_adGPBtp-Ed-ak6NoX_4Aeg_-1667450763")]
    [Description(@"Transaction is another type of transaction.")]
    OTHR,
    
    /// <summary>
    /// Transaction is a reinvestment of dividend.
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_adGPB9p-Ed-ak6NoX_4Aeg_1449121174")]
    [Description(@"Transaction is a reinvestment of dividend.")]
    RDIV,
    
    /// <summary>
    /// All types of transactions.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_QzUggFsIEea4y99eritluQ")]
    [Description(@"All types of transactions.")]
    ALLL,
    
    /// <summary>
    /// Purchase of securities.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_X5-aIFsIEea4y99eritluQ")]
    [Description(@"Purchase of securities.")]
    BUYI,
    
    /// <summary>
    /// Sale of securities.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_b2vxsFsIEea4y99eritluQ")]
    [Description(@"Sale of securities.")]
    SELL,
    
    /// <summary>
    /// Transaction is a cash withdrawal.
    /// </summary>
    [EnumMember(Value = "CWIT")]
    [IsoId("_ENCgAFsJEea4y99eritluQ")]
    [Description(@"Transaction is a cash withdrawal.")]
    CWIT,
    
    /// <summary>
    /// Transaction is a cash deposit.
    /// </summary>
    [EnumMember(Value = "CDEP")]
    [IsoId("_I4hXsFsJEea4y99eritluQ")]
    [Description(@"Transaction is a cash deposit.")]
    CDEP,
    
    /// <summary>
    /// Transaction is the payment of dividends and other proceeds.
    /// </summary>
    [EnumMember(Value = "DIVP")]
    [IsoId("_PSGI4FsJEea4y99eritluQ")]
    [Description(@"Transaction is the payment of dividends and other proceeds.")]
    DIVP,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundTransactionTypeCodeMetadataExtensions
{
    private static readonly InvestmentFundTransactionTypeCodeDropdownSource _dropdownSource = new InvestmentFundTransactionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundTransactionTypeCodeDropdownRow GetMetadata(this InvestmentFundTransactionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


