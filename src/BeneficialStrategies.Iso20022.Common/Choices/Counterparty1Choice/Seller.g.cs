﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Seller.  ISO2002 ID# _PYQBgNp-Ed-ak6NoX_4Aeg_1721008493.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Counterparty1Choice;

/// <summary>
/// Party that sells goods or services, or a financial instrument.
/// </summary>
public partial record Seller : Counterparty1Choice_
{
    #nullable enable
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification10Choice_ Identification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount13? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    public DateAndDateTimeChoice_? ProcessingDate { get; init; } 
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
