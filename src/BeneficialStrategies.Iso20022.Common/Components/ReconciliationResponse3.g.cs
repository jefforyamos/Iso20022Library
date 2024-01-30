﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReconciliationResponse3.  ISO2002 ID# _0k51cYYAEemxIqbaFEE8-w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of financial service to be used with this message of Reconciliation. This is only one service : ReconcialiationResponse.
/// </summary>
public partial record ReconciliationResponse3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment73 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public required CardPaymentContext27 Context { get; init; } 
    /// <summary>
    /// Content of the Reconciliation Response message.
    /// </summary>
    public required ReconciliationResponseData1 ReconciliationResponseData { get; init; } 
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    public required ResponseType9 Response { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
