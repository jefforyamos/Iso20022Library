﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SessionManagementResponse3.  ISO2002 ID# _RlB9EQ1WEeqjM-rxn3HuXQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of admin service to be used with this message.
/// </summary>
public partial record SessionManagementResponse3
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
    /// Define the type of service answered.
    /// </summary>
    public required RetailerService5Code ServiceContent { get; init; } 
    /// <summary>
    /// Content of the Login Response message.
    /// </summary>
    public LoginResponse2? LoginResponse { get; init; } 
    /// <summary>
    /// Content of the Diagnosis Response message.
    /// </summary>
    public DiagnosisResponse2? DiagnosisResponse { get; init; } 
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
