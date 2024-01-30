﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Details.  ISO2002 ID# _zeYEkBZNEe2QNcZTDeoKnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingPartyAndTime21Choice;

/// <summary>
/// Indicates that the contract is cleared and provides detailes of such clearing.
/// </summary>
public partial record Details : IClearingPartyAndTime21Choice
{
    #nullable enable
    /// <summary>
    /// Identifies the central counterparty (CCP) that cleared the transaction.
    /// </summary>
    public IOrganisationIdentification15Choice? CCP { get; init; } 
    /// <summary>
    /// Time and date when the original derivative was received by the central counterparty for clearing.
    /// </summary>
    public IsoISODateTime? ClearingReceiptDateTime { get; init; } 
    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    public IsoISODateTime? ClearingDateTime { get; init; } 
    /// <summary>
    /// Unique identifier of each clearing derivative that replaces the original derivative that was submitted for clearing to the central counterparty, other than the identifier for the transaction being reported.
    /// </summary>
    public IUniqueTransactionIdentifier2Choice? ClearingIdentifier { get; init; } 
    /// <summary>
    /// Unique identifier of the original derivative submitted for clearing to the central counterparty that is replaced by the clearing derivative.
    /// </summary>
    public IUniqueTransactionIdentifier2Choice? OriginalIdentifier { get; init; } 
    /// <summary>
    /// Identifies the trade repository to which the original derivative was reported.
    /// </summary>
    public IOrganisationIdentification15Choice? OriginalTradeRepositoryIdentifier { get; init; } 
    /// <summary>
    /// Indicator of whether the clearing member acted as principal for a house trade or an agent for a customer trade.
    /// </summary>
    public ClearingAccountType4Code? ClearingAccountOrigin { get; init; } 
    #nullable disable
}
