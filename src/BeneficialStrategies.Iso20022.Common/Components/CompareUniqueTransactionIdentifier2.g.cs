﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareUniqueTransactionIdentifier2.  ISO2002 ID# _Bil10TAvEe2Ne600gC45nw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a Transaction Identifier.
/// </summary>
public partial record CompareUniqueTransactionIdentifier2
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public IUniqueTransactionIdentifier2Choice? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public IUniqueTransactionIdentifier2Choice? Value2 { get; init; } 
    
    #nullable disable
}
