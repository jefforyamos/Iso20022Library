﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction158.  ISO2002 ID# _DabH0YgqEeu8-LhY4KPfWg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of transaction for a file action.
/// </summary>
public partial record Transaction158
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    public AdditionalFee2[] AdditionalFee { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1[] AdditionalData { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Details pertaining to the file action.
    /// </summary>
    public required FileActionDetails2 FileActionDetails { get; init; } 
    
    #nullable disable
}
