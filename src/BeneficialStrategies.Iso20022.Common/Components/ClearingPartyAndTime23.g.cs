﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClearingPartyAndTime23.  ISO2002 ID# _vlTr0RZOEe2QNcZTDeoKnQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the central counterparty intended clearing time.
/// </summary>
public partial record ClearingPartyAndTime23
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
    public IUniqueTransactionIdentifier1Choice? ClearingIdentifier { get; init; } 
    /// <summary>
    /// Unique identifier of the original derivative submitted for clearing to the central counterparty that is replaced by the clearing derivative.
    /// </summary>
    public IUniqueTransactionIdentifier1Choice? OriginalIdentifier { get; init; } 
    /// <summary>
    /// Identifies the trade repository to which the original derivative was reported.
    /// </summary>
    public IOrganisationIdentification15Choice? OriginalTradeRepositoryIdentifier { get; init; } 
    
    #nullable disable
}
