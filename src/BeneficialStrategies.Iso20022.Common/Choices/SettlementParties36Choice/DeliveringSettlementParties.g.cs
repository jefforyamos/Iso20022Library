﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DeliveringSettlementParties.  ISO2002 ID# _WKI1ISqSEeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementParties36Choice;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
public partial record DeliveringSettlementParties : SettlementParties36Choice_
{
    #nullable enable
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    public required PartyIdentification239Choice_ Depository { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    public required PartyIdentificationAndAccount200 Party1 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    public PartyIdentificationAndAccount201? Party2 { get; init; } 
    #nullable disable
}
