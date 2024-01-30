﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesAccount.  ISO2002 ID# _yNtKMTp1Eemk2e6qGBk8IQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountOrBusinessError3Choice;

/// <summary>
/// Specifies the data requested for the securities account.
/// </summary>
public partial record SecuritiesAccount : ISecuritiesAccountOrBusinessError3Choice
{
    #nullable enable
    /// <summary>
    /// Legal opening date of the securities account.
    /// </summary>
    public IsoISODate? OpeningDate { get; init; } 
    /// <summary>
    /// Legal closing date of the securities account.
    /// </summary>
    public IsoISODate? ClosingDate { get; init; } 
    /// <summary>
    /// Indicates whether the securities account is on hold or not.
    /// Usage:
    /// - Meaning when true: account is in hold status.
    /// - Meaning when false: account is in release status.
    /// </summary>
    public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the securities account can hold a negative position in a security or not.
    /// </summary>
    public IsoTrueFalseIndicator? NegativePosition { get; init; } 
    /// <summary>
    /// Specifies the type of the securities account.
    /// </summary>
    public ISystemSecuritiesAccountType1Choice? Type { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public required SystemPartyIdentification8 AccountOwner { get; init; } 
    /// <summary>
    /// Specifies the type of party owning the account.
    /// </summary>
    public ISystemPartyType1Choice? PartyType { get; init; } 
    /// <summary>
    /// Additional attributes defined by a central security depositary for a securities account.
    /// </summary>
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Defines the specific processing characteristics for a securities account to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    public SystemRestriction1? Restriction { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; } 
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    public IsoExact4AlphaNumericText? PricingScheme { get; init; } 
    #nullable disable
}
