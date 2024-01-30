﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties42.  ISO2002 ID# _N16I30GLEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies settlement parties (delivering/receiving).
/// </summary>
public partial record SettlementParties42
{
    #nullable enable
    
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the central securities depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    public PartyIdentification92? Depository { get; init; } 
    /// <summary>
    /// Party that interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount122? Party1 { get; init; } 
    /// <summary>
    /// Party that interacts with the party1.
    /// </summary>
    public PartyIdentificationAndAccount122? Party2 { get; init; } 
    /// <summary>
    /// Party that interacts with the party2.
    /// </summary>
    public PartyIdentificationAndAccount122? Party3 { get; init; } 
    
    #nullable disable
}
