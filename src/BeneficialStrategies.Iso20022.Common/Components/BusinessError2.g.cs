﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BusinessError2.  ISO2002 ID# _hDSckeL6EeWOD7aAy2fAcA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the business error details.
/// </summary>
public partial record BusinessError2
{
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Provides the business error.
    /// </summary>
    public ErrorHandling4? BusinessError { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
