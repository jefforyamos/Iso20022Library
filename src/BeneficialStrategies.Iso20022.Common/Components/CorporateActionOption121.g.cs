﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption121.  ISO2002 ID# _cfAHWZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption121
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IOptionNumber1Choice OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required ICorporateActionOption22Choice OptionType { get; init; } 
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    public IPartyIdentification103Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public IsoRestrictedFINXMax35Text? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    public ICashAccountIdentification6Choice? CashAccount { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public ISafekeepingPlaceFormat11Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    public SignedQuantityFormat8? TotalEligibleBalance { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    public SignedQuantityFormat8? InstructedBalance { get; init; } 
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    public SignedQuantityFormat8? UninstructedBalance { get; init; } 
    /// <summary>
    /// Quantity of securities that has been assigned the status indicated.
    /// </summary>
    public required IQuantity10Choice StatusQuantity { get; init; } 
    
    #nullable disable
}
