﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Context9.  ISO2002 ID# _7_YWUs5eEeiEmaZryQQ14Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card payment transaction is performed.
/// </summary>
public partial record Context9
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    public TransactionContext3? TransactionContext { get; init; } 
    
    #nullable disable
}
