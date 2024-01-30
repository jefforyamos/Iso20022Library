﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProprietaryStatusJustification1.  ISO2002 ID# _Ny9Dz5lPEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines proprietary reason to reject a transaction.
/// </summary>
public partial record ProprietaryStatusJustification1
{
    #nullable enable
    
    /// <summary>
    /// Defines the reason why the Target2 SSP system has rejected the transaction.
    /// </summary>
    public required IsoMax4AlphaNumericText ProprietaryStatusReason { get; init; } 
    /// <summary>
    /// Provides detailed information about the reason why the Target2 SSP system has rejected the transaction.
    /// </summary>
    public required IsoMax256Text Reason { get; init; } 
    
    #nullable disable
}
