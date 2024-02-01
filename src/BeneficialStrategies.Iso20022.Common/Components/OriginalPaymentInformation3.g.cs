﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInformation3.  ISO2002 ID# _PmG3Xdp-Ed-ak6NoX_4Aeg_-1414031304.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
public partial record OriginalPaymentInformation3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original payment information cancellation request.
    /// </summary>
    public IsoMax35Text? OriginalPaymentInformationCancellationIdentification { get; init; } 
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    public Case2? ResolvedCase { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    /// <summary>
    /// Specifies the status of a cancellation request, related to a payment information group.
    /// </summary>
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; } 
    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation status reason.
    /// </summary>
    public CancellationStatusReasonInformation1[] CancellationStatusReasonInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    public NumberOfCancellationsPerStatus1[] NumberOfTransactionsPerCancellationStatus { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the cancellation request message refers.
    /// </summary>
    public PaymentTransactionInformation32[] TransactionInformationAndStatus { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
