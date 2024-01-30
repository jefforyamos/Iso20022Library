﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CustodianForMinor.  ISO2002 ID# _envDaxdQEeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties2Choice;

/// <summary>
/// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
/// </summary>
public partial record CustodianForMinor : IAccountParties2Choice
{
    #nullable enable
    /// <summary>
    /// Information about the organisation or individual person.
    /// </summary>
    public required IParty14Choice Party { get; init; } 
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    public IMoneyLaunderingCheck1Choice? MoneyLaunderingCheck { get; init; } 
    /// <summary>
    /// Percentage of ownership or beneficiary ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
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
    /// Indicates whether the account owner signature is required to authorise transactions on the account.
    /// </summary>
    public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
    /// <summary>
    /// Information related to the party profile to be inserted or deleted.
    /// </summary>
    // public IReadOnlyCollection<ModificationScope14> ModifiedInvestorProfileValidation { get; init; }
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
