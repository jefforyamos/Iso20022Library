﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties80.  ISO2002 ID# _8GjfXPfREeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies settlement parties (delivering/receiving).
/// </summary>
public partial record SettlementParties80
{
    #nullable enable
    
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the central securities depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    public PartyIdentification155? Depository { get; init; } 
    /// <summary>
    /// Party that interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount173? Party1 { get; init; } 
    /// <summary>
    /// Party that interacts with the party1.
    /// </summary>
    public PartyIdentificationAndAccount173? Party2 { get; init; } 
    /// <summary>
    /// Party that interacts with the party2.
    /// </summary>
    public PartyIdentificationAndAccount173? Party3 { get; init; } 
    
    #nullable disable
}
