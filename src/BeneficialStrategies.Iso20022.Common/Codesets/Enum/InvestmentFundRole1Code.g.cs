﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundRole1Code.  ISO2002 ID# _Vi-eZtp-Ed-ak6NoX_4Aeg_1660914600.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role played by the actors in the investment funds industry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vi-eZtp-Ed-ak6NoX_4Aeg_1660914600")]
[Description(@"Specifies the role played by the actors in the investment funds industry.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InvestmentFundRole1Code
{
    /// <summary>
    /// Financial institution that executes cash transfers on behalf of its clients.
    /// Encoded/decoded by serializers as "CashCorrespondent".
    /// </summary>
    [EnumMember(Value = "CACO")]
    [IsoId("_Vi-eZ9p-Ed-ak6NoX_4Aeg_325528926")]
    [Description(@"Financial institution that executes cash transfers on behalf of its clients.")]
    CashCorrespondent,
    
    /// <summary>
    /// Party that safekeeps and administers assets on behalf of the owner.
    /// Encoded/decoded by serializers as "Custodian".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_Vi-eaNp-Ed-ak6NoX_4Aeg_477910264")]
    [Description(@"Party that safekeeps and administers assets on behalf of the owner.")]
    Custodian,
    
    /// <summary>
    /// Source of financial information. Provides financial news and data (for example, facts, statistics and analysis), for professional and individual investors through various media, for example, the Internet, magazines.
    /// Encoded/decoded by serializers as "DataProvider".
    /// </summary>
    [EnumMember(Value = "DATP")]
    [IsoId("_Vi-eadp-Ed-ak6NoX_4Aeg_436349307")]
    [Description(@"Source of financial information. Provides financial news and data (for example, facts, statistics and analysis), for professional and individual investors through various media, for example, the Internet, magazines.")]
    DataProvider,
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.
    /// Encoded/decoded by serializers as "FinalAgent".
    /// </summary>
    [EnumMember(Value = "FIAG")]
    [IsoId("_VjIPYNp-Ed-ak6NoX_4Aeg_-1199469611")]
    [Description(@"Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.")]
    FinalAgent,
    
    /// <summary>
    /// Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.
    /// Encoded/decoded by serializers as "FundManagementCompany".
    /// </summary>
    [EnumMember(Value = "FMCO")]
    [IsoId("_VjIPYdp-Ed-ak6NoX_4Aeg_508386038")]
    [Description(@"Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.")]
    FundManagementCompany,
    
    /// <summary>
    /// Party that keeps accounting records of the available assets and liabilities of the fund. This party calculates deal prices, the Net Asset Value (NAV) of the fund, and may provide fund performance and tax data.
    /// Encoded/decoded by serializers as "FundAccountant".
    /// </summary>
    [EnumMember(Value = "FACT")]
    [IsoId("_VjIPYtp-Ed-ak6NoX_4Aeg_778054036")]
    [Description(@"Party that keeps accounting records of the available assets and liabilities of the fund. This party calculates deal prices, the Net Asset Value (NAV) of the fund, and may provide fund performance and tax data.")]
    FundAccountant,
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as "Investor".
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_VjIPY9p-Ed-ak6NoX_4Aeg_-1128358093")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor,
    
    /// <summary>
    /// Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund's prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund.
    /// Encoded/decoded by serializers as "InvestmentManager".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_VjIPZNp-Ed-ak6NoX_4Aeg_1757620779")]
    [Description(@"Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund's prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund.")]
    InvestmentManager,
    
    /// <summary>
    /// Agent that executes the payment. In the context of the investment fund industry, the paying agent is the local legal representative of the fund. It may pay out dividends, and collects money for the purchase of funds when a client deals directly with the fund and/or when a client deals with bearer shares. It pays out the redemption of the fund, may distribute information about the fund, and provides legal information about the fund.
    /// Encoded/decoded by serializers as "PayingAgent".
    /// </summary>
    [EnumMember(Value = "PAYI")]
    [IsoId("_VjIPZdp-Ed-ak6NoX_4Aeg_379093110")]
    [Description(@"Agent that executes the payment. In the context of the investment fund industry, the paying agent is the local legal representative of the fund. It may pay out dividends, and collects money for the purchase of funds when a client deals directly with the fund and/or when a client deals with bearer shares. It pays out the redemption of the fund, may distribute information about the fund, and provides legal information about the fund.")]
    PayingAgent,
    
    /// <summary>
    /// Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.
    /// Encoded/decoded by serializers as "Registrar".
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_VjIPZtp-Ed-ak6NoX_4Aeg_1801946302")]
    [Description(@"Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.")]
    Registrar,
    
    /// <summary>
    /// Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as "TransferAgent".
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_VjIPZ9p-Ed-ak6NoX_4Aeg_833466392")]
    [Description(@"Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.")]
    TransferAgent,
    
    /// <summary>
    /// Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.
    /// Encoded/decoded by serializers as "Intermediary".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_VjIPaNp-Ed-ak6NoX_4Aeg_-1699296722")]
    [Description(@"Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.")]
    Intermediary,
    
    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// Encoded/decoded by serializers as "FirstAgent".
    /// </summary>
    [EnumMember(Value = "FTAG")]
    [IsoId("_VjIPadp-Ed-ak6NoX_4Aeg_486082931")]
    [Description(@"Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.")]
    FirstAgent,
    
    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as "Distributor".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_VjIPatp-Ed-ak6NoX_4Aeg_-285619")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor,
    
    /// <summary>
    /// Party that acts as an aggregator of funds, also called a funds hub.
    /// Encoded/decoded by serializers as "Concentrator".
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_VjSAYNp-Ed-ak6NoX_4Aeg_5257662")]
    [Description(@"Party that acts as an aggregator of funds, also called a funds hub.")]
    Concentrator,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundRole1CodeMetadataExtensions
{
    private static readonly InvestmentFundRole1CodeDropdownSource _dropdownSource = new InvestmentFundRole1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundRole1CodeDropdownRow GetMetadata(this InvestmentFundRole1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


