﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonFinancialResponseContentComponent3.  ISO2002 ID# _JlplIXJNEe299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aim of the non financial response.
/// </summary>
public partial record NonFinancialResponseContentComponent3
{
    #nullable enable
    
    /// <summary>
    /// Type of non financial request that the Acquirer processed.
    /// </summary>
    public required NonFinancialRequestType2Code NonFinancialRequestType { get; init; } 
    /// <summary>
    /// Identification of the most relevant Acquirer to process the transaction.
    /// </summary>
    public Acquirer10? AcquirerSelected { get; init; } 
    /// <summary>
    /// Advice from the Acquirer (or its Agent) to the POI to manage risk. 
    /// </summary>
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; init; } 
    /// <summary>
    /// Details of instalment supoported by the Service Provider.
    /// </summary>
    public RecurringTransaction5? Instalment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional elements sent by the ServiceProvider which are not linked to payment.
    /// </summary>
    public ExternallyDefinedData4? AdditionalResponse { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    public Action14? Action { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    public required ResponseType11 Response { get; init; } 
    
    #nullable disable
}
