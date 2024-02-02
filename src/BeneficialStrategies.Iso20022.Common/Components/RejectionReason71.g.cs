﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectionReason71.  ISO2002 ID# _yAw2W1yGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reasons of rejecting transactions.
/// </summary>
[DataContract]
[XmlType]
public partial record RejectionReason71
{
    #nullable enable
    
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [DataMember]
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    /// <summary>
    /// Information on status of submitted transactions.
    /// </summary>
    [DataMember]
    public required ReportingMessageStatus2Code Status { get; init; } 
    /// <summary>
    /// Acceptance criteria of the transaction.
    /// </summary>
    [DataMember]
    public ValueList<GenericValidationRuleIdentification1> DetailedValidationRule { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
