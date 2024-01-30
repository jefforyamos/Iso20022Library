﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption172.  ISO2002 ID# _bfb6DQVSEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption172
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IOptionNumber1Choice OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required ICorporateActionOption35Choice OptionType { get; init; } 
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    public IOptionFeaturesFormat27Choice? OptionFeatures { get; init; } 
    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    public IFractionDispositionType29Choice? FractionDisposition { get; init; } 
    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    public ICorporateActionChangeTypeFormat7Choice? ChangeType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies that the corporate action instruction is to be processed using the Available-for-Collateral pool.
    /// </summary>
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; } 
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
    /// </summary>
    public ActiveCurrencyCode? CurrencyToBuy { get; init; } 
    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction within this instruction message.
    /// </summary>
    public ActiveCurrencyCode? CurrencyToSell { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public SecurityIdentification20? SecurityIdentification { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    public required ISecuritiesQuantityOrAmount5Choice SecuritiesQuantityOrInstructedAmount { get; init; } 
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    public IDateAndDateTime2Choice? ExecutionRequestedDateTime { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    public CorporateActionRate73? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public CorporateActionPrice62? PriceDetails { get; init; } 
    /// <summary>
    /// Reference number assigned to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// </summary>
    public IsoRestrictedFINXMax25Text? ShareholderNumber { get; init; } 
    /// <summary>
    /// Provides additional information.
    /// </summary>
    public CorporateActionNarrative33? AdditionalInformation { get; init; } 
    
    #nullable disable
}
