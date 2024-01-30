﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesCollateral2.  ISO2002 ID# _H9e0cWA5EeSMf75YyPqG7w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the securities posted as collateral.
/// </summary>
public partial record SecuritiesCollateral2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    public IsoMax35Text? AssetNumber { get; init; } 
    /// <summary>
    /// Identification of a security.
    /// </summary>
    public required SecurityIdentification14 SecurityIdentification { get; init; } 
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    public IDateAndDateTimeChoice? MaturityDate { get; init; } 
    /// <summary>
    /// Indicates whether the collateral is proprietarily owned or client owned.
    /// </summary>
    public CollateralOwnership1? CollateralOwnership { get; init; } 
    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    /// <summary>
    /// Quantity of securities collateral.
    /// </summary>
    public required IFinancialInstrumentQuantity1Choice Quantity { get; init; } 
    /// <summary>
    /// Quantity blocked by the central counterparty for any reasonable reason ( for example for judicial reasons). In this case the investor can not withdraw or distribute this collateral.
    /// </summary>
    public IFinancialInstrumentQuantity1Choice? BlockedQuantity { get; init; } 
    /// <summary>
    /// Indicates the price of the security.
    /// </summary>
    public Price2? Price { get; init; } 
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
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public required ISafekeepingPlaceFormat7Choice SafekeepingPlace { get; init; } 
    
    #nullable disable
}
