﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction104.  ISO2002 ID# _FD25W249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original transactions, to which the status report message refers.
/// </summary>
[DataContract]
[XmlType]
public partial record PaymentTransaction104
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reported status.|Usage: The instructing party is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    [DataMember]
    public IsoMax35Text? StatusIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [DataMember]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; } 
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [DataMember]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [DataMember]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Status related to the requested conditions for the execution of the payment.
    /// </summary>
    [DataMember]
    public PaymentConditionStatus1? PaymentConditionStatus { get; init; } 
    /// <summary>
    /// Provides information on the charges related to the processing of the rejection of the instruction.|Usage: This is passed on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    [DataMember]
    public ValueList<Charges7> ChargesInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date and time on when the debtor has accepted or rejected the request.
    /// </summary>
    [DataMember]
    public IsoISODateTime? DebtorDecisionDateTime { get; init; } 
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [DataMember]
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountServicerReference { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ClearingSystemReference { get; init; } 
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [DataMember]
    public OriginalTransactionReference29? OriginalTransactionReference { get; init; } 
    /// <summary>
    /// Document or template enclosed in the notification.
    /// Usage: The use of the EnclosedFile element must be bilaterally agreed.
    /// </summary>
    [DataMember]
    public ValueList<Document12> EnclosedFile { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
