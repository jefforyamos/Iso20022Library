﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PrimaryOwner.  ISO2002 ID# _I9Ac8whDEeSUPbC7DbLJpQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties6Choice;

/// <summary>
/// Single owner of the investment account or, when the ownership is split among several owners, the primary owner is the one giving its address and account details for the registration.
/// </summary>
public partial record PrimaryOwner : IAccountParties6Choice
{
    #nullable enable
    /// <summary>
    /// Information about the organisation or individual person.
    /// </summary>
    public required IParty24Choice Party { get; init; } 
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
    public IReadOnlyCollection<ModificationScope19> ModifiedInvestorProfileValidation { get; init; } = [];
    /// <summary>
    /// Details about the MiFID classification of the account owner.
    /// </summary>
    public MiFIDClassification1? MiFIDClassification { get; init; } 
    /// <summary>
    /// Specifies how information is sent to the account holder.
    /// </summary>
    public InformationDistribution1Code? InformationDistribution { get; init; } 
    /// <summary>
    /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor.
    /// </summary>
    public IFATCAForm1Choice? FATCAFormType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Foreign Account Tax Compliance Act (FATCA) status of the investor.
    /// </summary>
    public FATCAStatus1? FATCAStatus { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
