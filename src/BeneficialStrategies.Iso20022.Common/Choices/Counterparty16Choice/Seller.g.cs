﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Seller.  ISO2002 ID# _c69UxTi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Counterparty16Choice;

/// <summary>
/// Party that sells goods or services, or a financial instrument.
/// </summary>
public partial record Seller : ICounterparty16Choice
{
    #nullable enable
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required IPartyIdentification137Choice Identification { get; init; } 
    /// <summary>
    /// Legal Entity Identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification9? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount30? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public BlockChainAddressWallet7? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    public IDateAndDateTime2Choice? ProcessingDate { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    public PartyTextInformation3? AdditionalInformation { get; init; } 
    #nullable disable
}
