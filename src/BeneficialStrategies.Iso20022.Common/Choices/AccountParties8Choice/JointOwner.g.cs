﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for JointOwner.  ISO2002 ID# _J1T_YSCBEeWhHbfCMWc1cw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties8Choice;

/// <summary>
/// Co-owner of the investment account when the ownership is assigned to more than one party.
/// </summary>
public partial record JointOwner : IAccountParties8Choice
{
    #nullable enable
    /// <summary>
    /// Information about the organisation or individual person.
    /// </summary>
    public required IParty31Choice Party { get; init; } 
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    public IMoneyLaunderingCheck1Choice? MoneyLaunderingCheck { get; init; } 
    /// <summary>
    /// Information to support Know Your Customer processes.
    /// </summary>
    public PartyProfileInformation5? InvestorProfileValidation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions or purchases and or redemptions or sells will be allocated using the same percentage.
    /// </summary>
    public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    public IsoMax35Text? ClientIdentification { get; init; } 
    /// <summary>
    /// Indicates whether an owner of the account may benefit from a fiscal exemption or amnesty, for example, when declaring overseas investments.
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
    /// Type of information that must be provided to the account holder.
    /// </summary>
    public Notification2? Notification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor or account owner.
    /// </summary>
    public IFATCAForm1Choice? FATCAFormType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Foreign Account Tax Compliance Act (FATCA) status of the investor or account owner.
    /// </summary>
    public FATCAStatus2? FATCAStatus { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, tax identification number. This may be an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    public GenericIdentification82? OtherIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Tax advantage specific to the account party.
    /// </summary>
    public ITaxExemptionReason2Choice? TaxExemption { get; init; } 
    /// <summary>
    /// Details for the reporting of tax, for example, the country of taxation.
    /// </summary>
    public TaxReporting1? TaxReporting { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Language in which the organisation or person communicates.
    /// </summary>
    public LanguageCode? Language { get; init; } 
    /// <summary>
    /// Method used for postal mailing.
    /// </summary>
    public IMailType1Choice? MailType { get; init; } 
    /// <summary>
    /// Country and residential status of the organisation or individual person.
    /// </summary>
    public CountryAndResidentialStatusType2? CountryAndResidentialStatus { get; init; } 
    /// <summary>
    /// Annual wealth of the individual person or share capital value of the legal entity and date on which the annual wealth of the individual person was registered or declared or the date the stock value of the organisation was registered.
    /// </summary>
    public DateAndAmount1? MonetaryWealth { get; init; } 
    /// <summary>
    /// Amount of total assets minus liabilities of the individual person or the amount of the difference between assets and liabilities plus rights over obligations (net equity) of the organisation and the date on which the equity value was registered.
    /// </summary>
    public DateAndAmount1? EquityValue { get; init; } 
    /// <summary>
    /// Resource or value owned or used by a third-party company and the date on which the working capital amount was registered.
    /// </summary>
    public DateAndAmount1? WorkingCapital { get; init; } 
    /// <summary>
    /// Account owner's connection with the trading party or broker.
    /// </summary>
    public ICompanyLink1Choice? CompanyLink { get; init; } 
    /// <summary>
    /// Reference to be specified when a letter (for example, an order confirmation) is sent by an automated mailing system.
    /// </summary>
    public IsoMax350Text? ElectronicMailingServiceReference { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress6? PrimaryCommunicationAddress { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress6? SecondaryCommunicationAddress { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional regulatory information about the investor or account owner that is required in some markets to support anti-money laundering laws.
    /// </summary>
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
    /// <summary>
    /// Specifies if the account party is regarded as domestic or non-domestic for reporting purposes.
    /// </summary>
    public IAccountingStatus1Choice? AccountingStatus { get; init; } 
    /// <summary>
    /// Additional information concerning limitations and restrictions on the account party.
    /// </summary>
    public AccountRestrictions1? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
