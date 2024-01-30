﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties26.  ISO2002 ID# _0fzamAlIEeGATtfOBToyew_1078318702.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
public partial record SettlementParties26
{
    #nullable enable
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    public PartyIdentificationAndAccount42? Party2 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 2.
    /// </summary>
    public PartyIdentificationAndAccount42? Party3 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 3.
    /// </summary>
    public PartyIdentificationAndAccount42? Party4 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 4.
    /// </summary>
    public PartyIdentificationAndAccount42? Party5 { get; init; } 
    
    #nullable disable
}
