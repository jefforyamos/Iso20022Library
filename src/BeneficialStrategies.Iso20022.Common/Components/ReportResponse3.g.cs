﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportResponse3.  ISO2002 ID# _yweH4Q1OEeqjM-rxn3HuXQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
public partial record ReportResponse3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment75 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public required CardPaymentContext28 Context { get; init; } 
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    public required RetailerService7Code ServiceContent { get; init; } 
    /// <summary>
    /// Content of the Transaction Report Response message.
    /// </summary>
    public ReportTransactionResponse2? ReportTransactionResponse { get; init; } 
    /// <summary>
    /// Content of the Get Totals Response message.
    /// </summary>
    public ReportGetTotalsResponse1? ReportGetTotalsResponse { get; init; } 
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
