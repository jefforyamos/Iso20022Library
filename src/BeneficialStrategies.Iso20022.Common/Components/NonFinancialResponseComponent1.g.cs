﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonFinancialResponseComponent1.  ISO2002 ID# _CTdnwC_uEeugIJ3Gvoevmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a non financial request.
/// </summary>
public partial record NonFinancialResponseComponent1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment77 Environment { get; init; } 
    /// <summary>
    /// Response of the non financial request.
    /// </summary>
    public NonFinancialResponseContentComponent1[] ResponseContent { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    public required ResponseType11 Response { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
