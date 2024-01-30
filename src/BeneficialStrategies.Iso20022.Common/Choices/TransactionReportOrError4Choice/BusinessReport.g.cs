﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessReport.  ISO2002 ID# _WnqHQW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionReportOrError4Choice;

/// <summary>
/// Reports on payment transactions.
/// </summary>
public partial record BusinessReport : ITransactionReportOrError4Choice
{
    #nullable enable
    /// <summary>
    /// Common detailed payment instruction information.
    /// </summary>
    public PaymentCommon4? PaymentCommonInformation { get; init; } 
    /// <summary>
    /// Indicates the total number and sum of the transactions.
    /// </summary>
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
    /// <summary>
    /// Reports either on the transaction information or on a business error.
    /// </summary>
    public TransactionReport5? TransactionReport { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
