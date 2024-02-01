﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Nominee.  ISO2002 ID# _5n7toBdAEeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties1Choice;

/// <summary>
/// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
/// </summary>
public partial record Nominee : AccountParties1Choice_
{
    #nullable enable
    /// <summary>
    /// Information about the organisation or individual person.
    /// </summary>
    public required Party14Choice_ Party { get; init; } 
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
    /// <summary>
    /// Information to support Know Your Customer processes.
    /// </summary>
    public PartyProfileInformation2? InvestorProfileValidation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
    /// </summary>
    public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    public IsoMax35Text? ClientIdentification { get; init; } 
    /// <summary>
    /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
    /// </summary>
    public IsoYesNoIndicator? FiscalExemption { get; init; } 
    /// <summary>
    /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
    /// </summary>
    public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
    /// <summary>
    /// Details about the MiFID classification of the account owner.
    /// </summary>
    public MiFIDClassification1? MiFIDClassification { get; init; } 
    /// <summary>
    /// Specifies how information is sent to the account holder.
    /// </summary>
    public InformationDistribution1Code? InformationDistribution { get; init; } 
    #nullable disable
}
