﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundType2Code.  ISO2002 ID# _e_zPoFKVEee26cwI-oG0JQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// In the case where the reporting counterparty is a UCIT or AIF, an indication whether it is an ETF or a MMF.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e_zPoFKVEee26cwI-oG0JQ")]
[Description(@"In the case where the reporting counterparty is a UCIT or AIF, an indication whether it is an ETF or a MMF.")]
[DerivedFrom(typeof(FundTypeCode))]
public enum FundType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExchangeTradedFund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_gipicVKVEee26cwI-oG0JQ")]
    [Description(@"??")]
    ExchangeTradedFund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MoneyMarketFund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_gowxgVKVEee26cwI-oG0JQ")]
    [Description(@"??")]
    MoneyMarketFund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_gukekVKVEee26cwI-oG0JQ")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RealEstateInvestmentTrust".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_g0YysVKVEee26cwI-oG0JQ")]
    [Description(@"??")]
    RealEstateInvestmentTrust,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundType2CodeMetadataExtensions
{
    private static readonly FundType2CodeDropdownSource _dropdownSource = new FundType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundType2CodeDropdownRow GetMetadata(this FundType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

