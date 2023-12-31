﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundRole7Code.  ISO2002 ID# _EfM6UF92EeS7xuKaq75oiQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EfM6UF92EeS7xuKaq75oiQ")]
[Description(@"Specifies the role of the party.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InvestmentFundRole7Code
{
    /// <summary>
    /// Party that acts as an aggregator of funds, also called a funds hub.
    /// Encoded/decoded by serializers as "Concentrator".
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_KLQeMV92EeS7xuKaq75oiQ")]
    [Description(@"Party that acts as an aggregator of funds, also called a funds hub.")]
    Concentrator,
    
    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as "Distributor".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_KxfXwV92EeS7xuKaq75oiQ")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor,
    
    /// <summary>
    /// Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.
    /// Encoded/decoded by serializers as "FundManagementCompany".
    /// </summary>
    [EnumMember(Value = "FMCO")]
    [IsoId("_La2d0V92EeS7xuKaq75oiQ")]
    [Description(@"Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.")]
    FundManagementCompany,
    
    /// <summary>
    /// Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.
    /// Encoded/decoded by serializers as "Intermediary".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_MBiDUV92EeS7xuKaq75oiQ")]
    [Description(@"Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.")]
    Intermediary,
    
    /// <summary>
    /// Agent that executes the payment. In the context of the investment fund industry, the paying agent is the local legal representative of the fund. It may pay out dividends, and collects money for the purchase of funds when a client deals directly with the fund and/or when a client deals with bearer shares. It pays out the redemption of the fund, may distribute information about the fund, and provides legal information about the fund.
    /// Encoded/decoded by serializers as "PayingAgent".
    /// </summary>
    [EnumMember(Value = "PAYI")]
    [IsoId("_NkBJwV92EeS7xuKaq75oiQ")]
    [Description(@"Agent that executes the payment. In the context of the investment fund industry, the paying agent is the local legal representative of the fund. It may pay out dividends, and collects money for the purchase of funds when a client deals directly with the fund and/or when a client deals with bearer shares. It pays out the redemption of the fund, may distribute information about the fund, and provides legal information about the fund.")]
    PayingAgent,
    
    /// <summary>
    /// Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as "TransferAgent".
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_OiXBUV92EeS7xuKaq75oiQ")]
    [Description(@"Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.")]
    TransferAgent,
    
    /// <summary>
    /// Party that safekeeps and administers assets on behalf of the owner.
    /// Encoded/decoded by serializers as "Custodian".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_9R7KwZy_EeSfkt2rmMY-dQ")]
    [Description(@"Party that safekeeps and administers assets on behalf of the owner.")]
    Custodian,
    
    /// <summary>
    /// Financial institution that executes cash transfers on behalf of its clients.
    /// Encoded/decoded by serializers as "CashCorrespondent".
    /// </summary>
    [EnumMember(Value = "CACO")]
    [IsoId("_-GJdAZy_EeSfkt2rmMY-dQ")]
    [Description(@"Financial institution that executes cash transfers on behalf of its clients.")]
    CashCorrespondent,
    
    /// <summary>
    /// Party that keeps accounting records of the available assets and liabilities of the fund. This party calculates deal prices, the Net Asset Value (NAV) of the fund, and may provide fund performance and tax data.
    /// Encoded/decoded by serializers as "FundAccountant".
    /// </summary>
    [EnumMember(Value = "FACT")]
    [IsoId("_-0HWQZy_EeSfkt2rmMY-dQ")]
    [Description(@"Party that keeps accounting records of the available assets and liabilities of the fund. This party calculates deal prices, the Net Asset Value (NAV) of the fund, and may provide fund performance and tax data.")]
    FundAccountant,
    
    /// <summary>
    /// Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund's prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund.
    /// Encoded/decoded by serializers as "InvestmentManager".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("__cb6gZy_EeSfkt2rmMY-dQ")]
    [Description(@"Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund's prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund.")]
    InvestmentManager,
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as "Investor".
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("__7OvUZy_EeSfkt2rmMY-dQ")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundRole7CodeMetadataExtensions
{
    private static readonly InvestmentFundRole7CodeDropdownSource _dropdownSource = new InvestmentFundRole7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundRole7CodeDropdownRow GetMetadata(this InvestmentFundRole7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


