﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption184.  ISO2002 ID# _KvJS0e6AEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption184
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IOptionNumber1Choice OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required ICorporateActionOption41Choice OptionType { get; init; } 
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    public IOptionFeaturesFormat25Choice? OptionFeatures { get; init; } 
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    public IPartyIdentification127Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    public ICashAccountIdentification5Choice? CashAccount { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public ISafekeepingPlaceFormat28Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    public SignedQuantityFormat7? TotalEligibleBalance { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    public SignedQuantityFormat7? InstructedBalance { get; init; } 
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    public SignedQuantityFormat7? UninstructedBalance { get; init; } 
    /// <summary>
    /// Quantity of securities that has been assigned the status indicated.
    /// </summary>
    public IQuantity6Choice? StatusQuantity { get; init; } 
    /// <summary>
    /// Amount of cash subscribed that has been assigned the status indicated.
    /// </summary>
    public IsoActiveCurrencyAndAmount? StatusCashAmount { get; init; } 
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    public IsoYesNoIndicator? SolicitationDealerFeeIndicator { get; init; } 
    
    #nullable disable
}
