﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Trustee.  ISO2002 ID# _J0DZtQhDEeSUPbC7DbLJpQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties7Choice;

/// <summary>
/// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
/// </summary>
public partial record Trustee : AccountParties7Choice_
{
    #nullable enable
    /// <summary>
    /// Information about the organisation or individual person.
    /// </summary>
    public required Party23Choice_ Party { get; init; } 
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
    /// <summary>
    /// Information to support Know Your Customer processes.
    /// </summary>
    public PartyProfileInformation4? InvestorProfileValidation { get; init;  } // Warning: Don't know multiplicity.
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
    /// <summary>
    /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor.
    /// </summary>
    public FATCAForm1Choice_? FATCAFormType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Foreign Account Tax Compliance Act (FATCA) status of the investor.
    /// </summary>
    public FATCAStatus1? FATCAStatus { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
