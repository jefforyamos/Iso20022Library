﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CounterpartySideTransactionReporting1.  ISO2002 ID# _Q6_ElE4REeOHYs5EqIAeTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This is regulatory transaction reporting information from the counterparty side party.
/// </summary>
public partial record CounterpartySideTransactionReporting1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the supervisory party to which the trade needs to be reported.
    /// </summary>
    public IsoMax35Text? ReportingJurisdiction { get; init; } 
    /// <summary>
    /// Identifies the party that is responsible for reporting the trade to the trade repository.
    /// </summary>
    public PartyIdentification73Choice_? ReportingParty { get; init; } 
    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI). This is the UTI from the Counterparty Side party.
    /// </summary>
    public UniqueTransactionIdentifier2[] CounterpartySideUniqueTransactionIdentifier { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
