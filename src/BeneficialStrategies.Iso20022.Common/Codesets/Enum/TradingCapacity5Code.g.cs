﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingCapacity5Code.  ISO2002 ID# _Yaalltp-Ed-ak6NoX_4Aeg_-1964739179.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yaalltp-Ed-ak6NoX_4Aeg_-1964739179")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[DerivedFrom(typeof(TradingCapacityCode))]
public enum TradingCapacity5Code
{
    /// <summary>
    /// Trading as Principal.
    /// Encoded/decoded by serializers as "PRIN".
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_Yaall9p-Ed-ak6NoX_4Aeg_524208854")]
    [Description(@"Trading as Principal.")]
    Principal = TradingCapacityCode.Principal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party.
    /// Encoded/decoded by serializers as "RISP".
    /// </summary>
    [EnumMember(Value = "RISP")]
    [IsoId("_YaalmNp-Ed-ak6NoX_4Aeg_789078674")]
    [Description(@"Trading as a riskless principal, ie, the order to buy(sell) has been simultaneously offset by an order to sell (buy) with another party.")]
    RisklessPrincipal = TradingCapacityCode.RisklessPrincipal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading as Agent on behalf of a customer.
    /// Encoded/decoded by serializers as "AGEN".
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_YajvgNp-Ed-ak6NoX_4Aeg_1711241984")]
    [Description(@"Trading as Agent on behalf of a customer.")]
    Agent = TradingCapacityCode.Agent, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingCapacity5CodeMetadataExtensions
{
    private static readonly TradingCapacity5CodeDropdownSource _dropdownSource = new TradingCapacity5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingCapacity5CodeDropdownRow GetMetadata(this TradingCapacity5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


