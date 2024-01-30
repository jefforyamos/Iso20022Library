﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesAccount.  ISO2002 ID# _hjB2cmliEeGaMcKyqKNRfQ_-884179545.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountOrBusinessError1Choice;

/// <summary>
/// Choice between data concerning securities account retrieved or business error.
/// </summary>
public partial record SecuritiesAccount : ISecuritiesAccountOrBusinessError1Choice
{
    #nullable enable
    /// <summary>
    /// Legal opening date for the securities account.
    /// </summary>
    public IsoISODate? OpeningDate { get; init; } 
    /// <summary>
    /// Legal closing date for the securities account.
    /// </summary>
    public IsoISODate? ClosingDate { get; init; } 
    /// <summary>
    /// Meaning when true: Account is in Hold status.
    /// Meaning when false: Account is in Release status.
    /// </summary>
    public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the securities account can hold a negative position in a security.
    /// </summary>
    public IsoYesNoIndicator? NegativePosition { get; init; } 
    /// <summary>
    /// Specifies the type of the securities account.
    /// </summary>
    public SystemSecuritiesAccountType1Code? Type { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public required SystemPartyIdentification3 AccountOwner { get; init; } 
    /// <summary>
    /// Specifies the type of the party owning the account.
    /// </summary>
    public SystemPartyType1Code? PartyType { get; init; } 
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
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
