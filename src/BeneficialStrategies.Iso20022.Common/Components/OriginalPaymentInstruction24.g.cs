﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInstruction24.  ISO2002 ID# _-ed9sZRuEeazAtAtDSg0Nw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original transactions, to which the status report message refers.
/// </summary>
[DataContract]
[XmlType]
public partial record OriginalPaymentInstruction24
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [DataMember]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [DataMember]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [DataMember]
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [DataMember]
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [DataMember]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [DataMember]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    [DataMember]
    public ValueList<PaymentTransaction83> TransactionInformationAndStatus { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
