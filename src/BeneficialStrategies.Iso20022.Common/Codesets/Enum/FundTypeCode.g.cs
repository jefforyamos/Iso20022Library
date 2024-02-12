﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundTypeCode.  ISO2002 ID# _sLXxUHaUEeaRItPFeGK_vQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// In the case where the reporting counterparty is a UCIT or AIF, an indication whether it is an ETF or a MMF.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sLXxUHaUEeaRItPFeGK_vQ")]
[Description(@"In the case where the reporting counterparty is a UCIT or AIF, an indication whether it is an ETF or a MMF.")]
[Derivations(typeof(FundType2Code))]
public enum FundTypeCode
{
    /// <summary>
    /// Fund of which at least one unit or share class is traded throughout the day on at
    /// least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value.|
    /// Encoded/decoded by serializers as "ETFT".
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_vJS7AHaUEeaRItPFeGK_vQ")]
    [Description(@"Fund of which at least one unit or share class is traded throughout the day on at|least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value.||")]
    ExchangeTradedFund,
    
    /// <summary>
    /// Indication that a fund is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund.
    /// Encoded/decoded by serializers as "MMFT".
    /// </summary>
    [EnumMember(Value = "MMFT")]
    [IsoId("_2i4-wHaUEeaRItPFeGK_vQ")]
    [Description(@"Indication that a fund is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund.")]
    MoneyMarketFund,
    
    /// <summary>
    /// Other type of an investment fund. 
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_5A2O8HaUEeaRItPFeGK_vQ")]
    [Description(@"Other type of an investment fund. ")]
    Other,
    
    /// <summary>
    /// Listed real investment company.
    /// Encoded/decoded by serializers as "REIT".
    /// </summary>
    [EnumMember(Value = "REIT")]
    [IsoId("_Xa-MQFKVEee26cwI-oG0JQ")]
    [Description(@"Listed real investment company.")]
    RealEstateInvestmentTrust,
    
}
