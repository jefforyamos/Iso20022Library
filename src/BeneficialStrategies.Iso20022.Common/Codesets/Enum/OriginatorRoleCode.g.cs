﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OriginatorRoleCode.  ISO2002 ID# _Zw_W9tp-Ed-ak6NoX_4Aeg_141531855.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies in what capacity (role) the originator of a quote is acting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zw_W9tp-Ed-ak6NoX_4Aeg_141531855")]
[Description(@"Specifies in what capacity (role) the originator of a quote is acting.")]
[Derivations(typeof(OriginatorRole2Code),typeof(OriginatorRole1Code))]
// External derivations that should be provided by the proper interface are: 
public enum OriginatorRoleCode
{
    /// <summary>
    /// Firms which, on an organised, frequent and systematic basis deal on their own account by executing client orders outside a regulated market or a Multilateral Trading Facility. SI's will have the obligation to provide, and make public, a definite bid and offer quote for liquid securities. They act as "mini"exchanges.
    /// Encoded/decoded by serializers as "SINT".
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_Zw_W99p-Ed-ak6NoX_4Aeg_226493959")]
    [Description(@"Firms which, on an organised, frequent and systematic basis deal on their own account by executing client orders outside a regulated market or a Multilateral Trading Facility. SI's will have the obligation to provide, and make public, a definite bid and offer quote for liquid securities. They act as ""mini""exchanges.")]
    SystematicInternaliser,
    
    /// <summary>
    /// Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as "MLTF".
    /// </summary>
    [EnumMember(Value = "MLTF")]
    [IsoId("_Zw_W-Np-Ed-ak6NoX_4Aeg_285598955")]
    [Description(@"Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.")]
    MultilateralTradingFacility,
    
    /// <summary>
    /// Market on which financial instruments can be traded according to rules defined by the stock exchange.
    /// Encoded/decoded by serializers as "RMKT".
    /// </summary>
    [EnumMember(Value = "RMKT")]
    [IsoId("_ZxJH8Np-Ed-ak6NoX_4Aeg_618069199")]
    [Description(@"Market on which financial instruments can be traded according to rules defined by the stock exchange.")]
    RegulatedMarket,
    
    /// <summary>
    /// Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell.
    /// Encoded/decoded by serializers as "MKTM".
    /// </summary>
    [EnumMember(Value = "MKTM")]
    [IsoId("_ZxJH8dp-Ed-ak6NoX_4Aeg_699337620")]
    [Description(@"Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell.")]
    MarketMaker,
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_ZxJH8tp-Ed-ak6NoX_4Aeg_774141539")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor,
    
    /// <summary>
    /// Party appointed by the fund management company. It updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as "TAGT".
    /// </summary>
    [EnumMember(Value = "TAGT")]
    [IsoId("_ZxJH89p-Ed-ak6NoX_4Aeg_2134774844")]
    [Description(@"Party appointed by the fund management company. It updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.")]
    TransfertAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OriginatorRoleCodeMetadataExtensions
{
    private static readonly OriginatorRoleCodeDropdownSource _dropdownSource = new OriginatorRoleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOriginatorRoleCodeDropdownRow GetMetadata(this OriginatorRoleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


