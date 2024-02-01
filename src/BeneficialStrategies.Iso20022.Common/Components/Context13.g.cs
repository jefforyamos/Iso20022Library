﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Context13.  ISO2002 ID# _61__UahMEeuOaMA1YOy5YQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card payment transaction is performed.
/// </summary>
public partial record Context13
{
    #nullable enable
    
    /// <summary>
    /// Contains point of interaction information specific to a given transaction that may change from transaction to transaction.
    /// </summary>
    public PointOfServiceContext4? PointOfServiceContext { get; init; } 
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    public TransactionContext8? TransactionContext { get; init; } 
    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify  the cardholder or his card.
    /// </summary>
    public Verification4[] Verification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    public RiskContext2? RiskContext { get; init; } 
    
    #nullable disable
}
