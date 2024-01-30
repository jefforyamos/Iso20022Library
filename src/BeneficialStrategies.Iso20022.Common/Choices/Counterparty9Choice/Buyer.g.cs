﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Buyer.  ISO2002 ID# _GiI3ex5dEeWE3PufGMdJ3w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Counterparty9Choice;

/// <summary>
/// Party that buys goods or services, or a financial instrument.
/// </summary>
public partial record Buyer : ICounterparty9Choice
{
    #nullable enable
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required IPartyIdentification71Choice Identification { get; init; } 
    /// <summary>
    /// Legal Entity Identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount24? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    public IDateAndDateTimeChoice? ProcessingDate { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    #nullable disable
}
