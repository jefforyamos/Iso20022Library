﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesCollateral12.  ISO2002 ID# _Wh-tcyqSEeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the securities posted as collateral.
/// </summary>
public partial record SecuritiesCollateral12
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    public IsoMax35Text? CollateralIdentification { get; init; } 
    /// <summary>
    /// Identification of a security.
    /// </summary>
    public required SecurityIdentification19 SecurityIdentification { get; init; } 
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    public DateAndDateTime2Choice_? MaturityDate { get; init; } 
    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    /// <summary>
    /// Quantity of securities collateral.
    /// </summary>
    public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; } 
    /// <summary>
    /// Indicates the price of the security.
    /// </summary>
    public Price7? Price { get; init; } 
    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    public IsoActiveCurrencyAndAmount? MarketValue { get; init; } 
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    public IsoPercentageRate? Haircut { get; init; } 
    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CollateralValue { get; init; } 
    /// <summary>
    /// Valuation date of the securities taken as collateral.
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public required SafekeepingPlaceFormat29Choice_ SafekeepingPlace { get; init; } 
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    public SettlementDetails206? SettlementParameters { get; init; } 
    
    #nullable disable
}
