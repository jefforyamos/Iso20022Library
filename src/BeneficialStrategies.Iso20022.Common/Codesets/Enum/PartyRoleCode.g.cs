﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyRoleCode.  ISO2002 ID# _ZxlM1tp-Ed-ak6NoX_4Aeg_492772100.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the party in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxlM1tp-Ed-ak6NoX_4Aeg_492772100")]
[Description(@"Specifies the role of the party in the transaction.")]
[Derivations(typeof(InvestmentFundRole1Code),typeof(InvestmentFundRole3Code),typeof(InvestmentFundRole2Code),typeof(PaymentRole1Code),typeof(InvestmentFundRole4Code),typeof(InvestmentFundRole5Code),typeof(InvestmentFundRole6Code),typeof(InvestmentFundRole7Code),typeof(InternalPartyRole1Code),typeof(PartyRole1Code),typeof(PartyRole2Code),typeof(PartyRole3Code),typeof(InvestmentFundRole8Code))]
// External derivations that should be provided by the proper interface are: 
public enum PartyRoleCode
{
    /// <summary>
    /// Party in a financial institution responsible for the management of liquidity for the financial institution. This party has access to some functions available on the system, such as the liquidity transfers ormanagement of standing instructions for liquidity control.
    /// Encoded/decoded by serializers as "LQMG".
    /// </summary>
    [EnumMember(Value = "LQMG")]
    [IsoId("_ZxlM19p-Ed-ak6NoX_4Aeg_-739409616")]
    [Description(@"Party in a financial institution responsible for the management of liquidity for the financial institution. This party has access to some functions available on the system, such as the liquidity transfers ormanagement of standing instructions for liquidity control.")]
    LiquidityManager,
    
    /// <summary>
    /// Party in a financial institution responsible for the management of the limits. This party is responsible for fixing, modifying, or suspending limits as relevant for the management of counterpart risk or systemic risk containment.
    /// Encoded/decoded by serializers as "LMMG".
    /// </summary>
    [EnumMember(Value = "LMMG")]
    [IsoId("_ZxlM2Np-Ed-ak6NoX_4Aeg_318019466")]
    [Description(@"Party in a financial institution responsible for the management of the limits. This party is responsible for fixing, modifying, or suspending limits as relevant for the management of counterpart risk or systemic risk containment.")]
    LimitManager,
    
    /// <summary>
    /// Party in a financial institution responsible for the management of payment processing for the financial institution. This includes authorising, recycling, and modification of payment transactions.
    /// Encoded/decoded by serializers as "PYMG".
    /// </summary>
    [EnumMember(Value = "PYMG")]
    [IsoId("_Zxu90Np-Ed-ak6NoX_4Aeg_323559833")]
    [Description(@"Party in a financial institution responsible for the management of payment processing for the financial institution. This includes authorising, recycling, and modification of payment transactions.")]
    PaymentManager,
    
    /// <summary>
    /// Party in a financial institution entitled to obtain information from the system, but not act upon/alter this information.
    /// Encoded/decoded by serializers as "REDR".
    /// </summary>
    [EnumMember(Value = "REDR")]
    [IsoId("_Zxu90dp-Ed-ak6NoX_4Aeg_345726538")]
    [Description(@"Party in a financial institution entitled to obtain information from the system, but not act upon/alter this information.")]
    Reader,
    
    /// <summary>
    /// Party responsible for managing the recovery functions related to a system.
    /// Encoded/decoded by serializers as "BKMG".
    /// </summary>
    [EnumMember(Value = "BKMG")]
    [IsoId("_Zxu90tp-Ed-ak6NoX_4Aeg_352190658")]
    [Description(@"Party responsible for managing the recovery functions related to a system.")]
    BackupManager,
    
    /// <summary>
    /// Party in a financial institution responsible for the management of settlement processing.
    /// Encoded/decoded by serializers as "STMG".
    /// </summary>
    [EnumMember(Value = "STMG")]
    [IsoId("_Zxu909p-Ed-ak6NoX_4Aeg_375279643")]
    [Description(@"Party in a financial institution responsible for the management of settlement processing.")]
    SettlementManager,
    
    /// <summary>
    /// Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.
    /// Encoded/decoded by serializers as "FMCO".
    /// </summary>
    [EnumMember(Value = "FMCO")]
    [IsoId("_Zxu91Np-Ed-ak6NoX_4Aeg_915740929")]
    [Description(@"Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.")]
    FundManagementCompany,
    
    /// <summary>
    /// Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as "TRAG".
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_Zxu91dp-Ed-ak6NoX_4Aeg_1387662655")]
    [Description(@"Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.")]
    TransferAgent,
    
    /// <summary>
    /// Party that keeps accounting records of the available assets and liabilities of the fund. This party calculates deal prices, the Net Asset Value (NAV) of the fund, and may provide fund performance and tax data.
    /// Encoded/decoded by serializers as "FACT".
    /// </summary>
    [EnumMember(Value = "FACT")]
    [IsoId("_Zxu91tp-Ed-ak6NoX_4Aeg_445405292")]
    [Description(@"Party that keeps accounting records of the available assets and liabilities of the fund. This party calculates deal prices, the Net Asset Value (NAV) of the fund, and may provide fund performance and tax data.")]
    FundAccountant,
    
    /// <summary>
    /// Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.
    /// Encoded/decoded by serializers as "REGI".
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_Zxu919p-Ed-ak6NoX_4Aeg_782488757")]
    [Description(@"Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.")]
    Registrar,
    
    /// <summary>
    /// Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund's prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_Zxu92Np-Ed-ak6NoX_4Aeg_1614581583")]
    [Description(@"Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund's prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund.")]
    InvestmentManager,
    
    /// <summary>
    /// Party that safekeeps and administers assets on behalf of the owner.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_Zxu92dp-Ed-ak6NoX_4Aeg_1700470454")]
    [Description(@"Party that safekeeps and administers assets on behalf of the owner.")]
    Custodian,
    
    /// <summary>
    /// Party that regularly monitors compliance with the legal regulations.
    /// Encoded/decoded by serializers as "AUDT".
    /// </summary>
    [EnumMember(Value = "AUDT")]
    [IsoId("_Zx4u0Np-Ed-ak6NoX_4Aeg_2000611780")]
    [Description(@"Party that regularly monitors compliance with the legal regulations.")]
    Auditor,
    
    /// <summary>
    /// Agent that executes the payment. In the context of the investment fund industry, the paying agent is the local legal representative of the fund. It may pay out dividends, and collects money for the purchase of funds when a client deals directly with the fund and/or when a client deals with bearer shares. It pays out the redemption of the fund, may distribute information about the fund, and provides legal information about the fund.
    /// Encoded/decoded by serializers as "PAYI".
    /// </summary>
    [EnumMember(Value = "PAYI")]
    [IsoId("_Zx4u0dp-Ed-ak6NoX_4Aeg_2069877402")]
    [Description(@"Agent that executes the payment. In the context of the investment fund industry, the paying agent is the local legal representative of the fund. It may pay out dividends, and collects money for the purchase of funds when a client deals directly with the fund and/or when a client deals with bearer shares. It pays out the redemption of the fund, may distribute information about the fund, and provides legal information about the fund.")]
    PayingAgent,
    
    /// <summary>
    /// Financial institution that executes cash transfers on behalf of its clients.
    /// Encoded/decoded by serializers as "CACO".
    /// </summary>
    [EnumMember(Value = "CACO")]
    [IsoId("_Zx4u0tp-Ed-ak6NoX_4Aeg_-1851064913")]
    [Description(@"Financial institution that executes cash transfers on behalf of its clients.")]
    CashCorrespondent,
    
    /// <summary>
    /// Source of financial information. Provides financial news and data (for example, facts, statistics and analysis), for professional and individual investors through various media, for example, the Internet, magazines.
    /// Encoded/decoded by serializers as "DATP".
    /// </summary>
    [EnumMember(Value = "DATP")]
    [IsoId("_Zx4u09p-Ed-ak6NoX_4Aeg_-1427187447")]
    [Description(@"Source of financial information. Provides financial news and data (for example, facts, statistics and analysis), for professional and individual investors through various media, for example, the Internet, magazines.")]
    DataProvider,
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.
    /// Encoded/decoded by serializers as "FIAG".
    /// </summary>
    [EnumMember(Value = "FIAG")]
    [IsoId("_Zx4u1Np-Ed-ak6NoX_4Aeg_-1297894986")]
    [Description(@"Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.")]
    FinalAgent,
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as "INVS".
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_Zx4u1dp-Ed-ak6NoX_4Aeg_1192841077")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor,
    
    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// Encoded/decoded by serializers as "FTAG".
    /// </summary>
    [EnumMember(Value = "FTAG")]
    [IsoId("_Zx4u1tp-Ed-ak6NoX_4Aeg_866713469")]
    [Description(@"Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.")]
    FirstAgent,
    
    /// <summary>
    /// Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.
    /// Encoded/decoded by serializers as "INTR".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_Zx4u19p-Ed-ak6NoX_4Aeg_-1252110402")]
    [Description(@"Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.")]
    Intermediary,
    
    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as "DIST".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_Zx4u2Np-Ed-ak6NoX_4Aeg_-1445593817")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor,
    
    /// <summary>
    /// Party that acts as an aggregator of funds, also called a funds hub.
    /// Encoded/decoded by serializers as "CONC".
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_Zx4u2dp-Ed-ak6NoX_4Aeg_-170213237")]
    [Description(@"Party that acts as an aggregator of funds, also called a funds hub.")]
    Concentrator,
    
    /// <summary>
    /// Underlying client of the intermediary.
    /// Encoded/decoded by serializers as "UCL1".
    /// </summary>
    [EnumMember(Value = "UCL1")]
    [IsoId("_Zx4u2tp-Ed-ak6NoX_4Aeg_827265900")]
    [Description(@"Underlying client of the intermediary.")]
    UnderlyingClient1,
    
    /// <summary>
    /// Underlying client of underlying client 1.
    /// Encoded/decoded by serializers as "UCL2".
    /// </summary>
    [EnumMember(Value = "UCL2")]
    [IsoId("_ZyB4wNp-Ed-ak6NoX_4Aeg_827266363")]
    [Description(@"Underlying client of underlying client 1.")]
    UnderlyingClient2,
    
    /// <summary>
    /// Party that transmits the instruction, advice, notification or report.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZyB4wdp-Ed-ak6NoX_4Aeg_827266536")]
    [Description(@"Party that transmits the instruction, advice, notification or report.")]
    TransmittingAgent,
    
    /// <summary>
    /// Party acting as an intermediary agent between an investor and a transfer agent for the subscription or redemption to a fund.
    /// Encoded/decoded by serializers as "FNBR".
    /// </summary>
    [EnumMember(Value = "FNBR")]
    [IsoId("_ZyB4wtp-Ed-ak6NoX_4Aeg_827266908")]
    [Description(@"Party acting as an intermediary agent between an investor and a transfer agent for the subscription or redemption to a fund.")]
    FundBroker,
    
    /// <summary>
    /// Party that supplies information and advice on investment products.
    /// Encoded/decoded by serializers as "FIAD".
    /// </summary>
    [EnumMember(Value = "FIAD")]
    [IsoId("_ZyB4w9p-Ed-ak6NoX_4Aeg_827267251")]
    [Description(@"Party that supplies information and advice on investment products.")]
    FinancialAdvisor,
    
    /// <summary>
    /// Party acting as the contact person at the instructing party institution.
    /// Encoded/decoded by serializers as "CONI".
    /// </summary>
    [EnumMember(Value = "CONI")]
    [IsoId("_ZyB4xNp-Ed-ak6NoX_4Aeg_-322845161")]
    [Description(@"Party acting as the contact person at the instructing party institution.")]
    ContactPersonAtInstructingPartyInstitution,
    
    /// <summary>
    /// Party acting as the contact person at the executing party institution.
    /// Encoded/decoded by serializers as "CONE".
    /// </summary>
    [EnumMember(Value = "CONE")]
    [IsoId("_ZyB4xdp-Ed-ak6NoX_4Aeg_-322844568")]
    [Description(@"Party acting as the contact person at the executing party institution.")]
    ContactPersonAtExecutingPartyInstitution,
    
    /// <summary>
    /// Name of Agent to the order, if different from the instructing party.
    /// Encoded/decoded by serializers as "CONA".
    /// </summary>
    [EnumMember(Value = "CONA")]
    [IsoId("_ZyB4xtp-Ed-ak6NoX_4Aeg_-322843887")]
    [Description(@"Name of Agent to the order, if different from the instructing party.")]
    NameOfAgentToOrder,
    
    /// <summary>
    /// Party acting as settlement agent, provides custody for assets, provides financing for leverage, and prepares daily account statements for its clients, who are money managers, hedge funds, market makers, arbitrageurs, specialists and other professional investors.
    /// Encoded/decoded by serializers as "PRBR".
    /// </summary>
    [EnumMember(Value = "PRBR")]
    [IsoId("_ZyB4x9p-Ed-ak6NoX_4Aeg_-321923018")]
    [Description(@"Party acting as settlement agent, provides custody for assets, provides financing for leverage, and prepares daily account statements for its clients, who are money managers, hedge funds, market makers, arbitrageurs, specialists and other professional investors.")]
    PrimeBroker,
    
    /// <summary>
    /// Party acting as an internal agent.
    /// Encoded/decoded by serializers as "INTC".
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_0mmtoAkhEeWGouz230Xp5Q")]
    [Description(@"Party acting as an internal agent.")]
    Internal,
    
    /// <summary>
    /// Party that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// Encoded/decoded by serializers as "LGRD".
    /// </summary>
    [EnumMember(Value = "LGRD")]
    [IsoId("_fXRWYI6NEemzmeK8_tPygg")]
    [Description(@"Party that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.")]
    LegalGuardian,
    
    /// <summary>
    /// Party that is authorised to take investment decisions on behalf of the shareholder.
    /// Encoded/decoded by serializers as "DECM".
    /// </summary>
    [EnumMember(Value = "DECM")]
    [IsoId("_qbAwoI6NEemzmeK8_tPygg")]
    [Description(@"Party that is authorised to take investment decisions on behalf of the shareholder.")]
    DecisionMaker,
    
    /// <summary>
    /// Legal entity, other than the issuer, who gives a guarantee. The guarantor becomes liable in case of default.
    /// Encoded/decoded by serializers as "GATR".
    /// </summary>
    [EnumMember(Value = "GATR")]
    [IsoId("_gAoCoPRCEeqAradXpAelDQ")]
    [Description(@"Legal entity, other than the issuer, who gives a guarantee. The guarantor becomes liable in case of default.")]
    Guarantor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyRoleCodeMetadataExtensions
{
    private static readonly PartyRoleCodeDropdownSource _dropdownSource = new PartyRoleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyRoleCodeDropdownRow GetMetadata(this PartyRoleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


