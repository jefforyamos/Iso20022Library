﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInstruction6.  ISO2002 ID# _yHpSMSHQEeKGep4bhmamiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details information on the original transactions, to which the status report message refers.
/// </summary>
public partial record OriginalPaymentInstruction6
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation9[] StatusReasonInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    public NumberOfTransactionsPerStatus3[] NumberOfTransactionsPerStatus { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    public PaymentTransaction46[] TransactionInformationAndStatus { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
