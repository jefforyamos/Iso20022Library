﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountBalanceSD10.  ISO2002 ID# _hn-gQb5YEeexmbB7KsjCwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
public partial record AccountBalanceSD10
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Position that is concerned in transaction.
    /// </summary>
    public IAdjustedBalanceTypeSD4Choice? TransactionPosition { get; init; } 
    /// <summary>
    /// Transaction contra participant identification for stock loans, repurchase agreements (REPOs).
    /// </summary>
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    #nullable disable
}
