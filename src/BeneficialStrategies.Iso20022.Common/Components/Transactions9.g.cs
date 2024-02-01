﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transactions9.  ISO2002 ID# _df3oMdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on transactions.
/// </summary>
public partial record Transactions9
{
    #nullable enable
    
    /// <summary>
    /// Common detailed payment instruction information.
    /// </summary>
    public PaymentCommon5? PaymentCommonInformation { get; init; } 
    /// <summary>
    /// Indicates the total number and sum of the transactions.
    /// </summary>
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
    /// <summary>
    /// Reports either on the transaction information or on a business error.
    /// </summary>
    public TransactionReport6[] TransactionReport { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
