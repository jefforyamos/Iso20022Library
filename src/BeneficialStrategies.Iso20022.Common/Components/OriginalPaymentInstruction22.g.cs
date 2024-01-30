﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInstruction22.  ISO2002 ID# _UXQgr2XlEeap-P22vGV91g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the reference and status of the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
public partial record OriginalPaymentInstruction22
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original payment information cancellation request.
    /// </summary>
    public IsoMax35Text? OriginalPaymentInformationCancellationIdentification { get; init; } 
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    public Case3? ResolvedCase { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Provides information on the original message.
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
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    public NumberOfCancellationsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    public PaymentTransaction78? TransactionInformationAndStatus { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
