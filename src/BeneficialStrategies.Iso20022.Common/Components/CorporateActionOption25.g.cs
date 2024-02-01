﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption25.  ISO2002 ID# _yBJdUeEPEd-1Ktb5rVaajw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption25
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption4Choice_ OptionType { get; init; } 
    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    public FractionDispositionType10Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    public CorporateActionChangeTypeFormat2Choice_[] ChangeType { get; init; } = []; // Warning: Don't know multiplicity.
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
    public SecurityIdentification14? SecurityIdentification { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    public required SecuritiesOption2 SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    public DateAndDateTimeChoice_? ExecutionRequestedDateTime { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    public CorporateActionRate8? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public CorporateActionPrice19? PriceDetails { get; init; } 
    /// <summary>
    /// Provides additional information.
    /// </summary>
    public CorporateActionNarrative8? AdditionalInformation { get; init; } 
    
    #nullable disable
}
