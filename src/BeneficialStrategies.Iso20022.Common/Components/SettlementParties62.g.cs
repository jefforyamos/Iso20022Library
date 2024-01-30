﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties62.  ISO2002 ID# _NVmdca5YEeey8N0JWnVPUw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
public partial record SettlementParties62
{
    #nullable enable
    
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    public PartyIdentification127? Depository { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount159? Party1 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    public PartyIdentificationAndAccount159? Party2 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 2.
    /// </summary>
    public PartyIdentificationAndAccount159? Party3 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 3.
    /// </summary>
    public PartyIdentificationAndAccount159? Party4 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 4.
    /// </summary>
    public PartyIdentificationAndAccount159? Party5 { get; init; } 
    
    #nullable disable
}
