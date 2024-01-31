﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPaymentCancellationRejection1Code.  ISO2002 ID# _-LDBoIlyEeePr-EGJjGYzQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the rejection of a cancellation, as published in an external payment cancellation rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-LDBoIlyEeePr-EGJjGYzQ")]
[Description(@"Specifies the reason for the rejection of a cancellation, as published in an external payment cancellation rejection code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPaymentCancellationRejectionCode))]
public enum ExternalPaymentCancellationRejection1Code
{
    /// <summary>
    /// Account number specified has been closed on the receiver’s books.
    /// Encoded/decoded by serializers as "AC04".
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_ubqEQvRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the receiver’s books.")]
    ClosedAccountNumber = ExternalPaymentCancellationRejectionCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation request cannot be processed because customer has not yet provided the debit authority on its account.
    /// Encoded/decoded by serializers as "ADAC".
    /// </summary>
    [EnumMember(Value = "ADAC")]
    [IsoId("_ubqERfRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation request cannot be processed because customer has not yet provided the debit authority on its account.")]
    AwaitingDebitAuthorityFromCustomer = ExternalPaymentCancellationRejectionCode.AwaitingDebitAuthorityFromCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of an agent refuses to cancel.
    /// Encoded/decoded by serializers as "AGNT".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_ubqESPRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation cannot be accepted because of an agent refuses to cancel.")]
    AgentDecision = ExternalPaymentCancellationRejectionCode.AgentDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as "AM04".
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_ubqES_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds = ExternalPaymentCancellationRejectionCode.InsufficientFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation not accepted as the transaction has already been returned.
    /// Encoded/decoded by serializers as "ARDT".
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("_ubqETvRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation not accepted as the transaction has already been returned.")]
    AlreadyReturned = ExternalPaymentCancellationRejectionCode.AlreadyReturned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation request cannot be processed because no reply has been  received yet from the receiver of the request message.
    /// Encoded/decoded by serializers as "ARPL".
    /// </summary>
    [EnumMember(Value = "ARPL")]
    [IsoId("_ubzOMvRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation request cannot be processed because no reply has been  received yet from the receiver of the request message.")]
    AwaitinReply = ExternalPaymentCancellationRejectionCode.AwaitinReply, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of a customer decision (Creditor).
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ubzONfRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation cannot be accepted because of a customer decision (Creditor).")]
    CustomerDecision = ExternalPaymentCancellationRejectionCode.CustomerDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of regulatory rules.
    /// Encoded/decoded by serializers as "LEGL".
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_ub8_MvRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation cannot be accepted because of regulatory rules.")]
    LegalDecision = ExternalPaymentCancellationRejectionCode.LegalDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as "NARR".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_ub8_NfRYEeuLhpyIdtJzwg")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    Narrative = ExternalPaymentCancellationRejectionCode.Narrative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No response from beneficiary (to the cancellation request).
    /// Encoded/decoded by serializers as "NOAS".
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_ucGJIvRYEeuLhpyIdtJzwg")]
    [Description(@"No response from beneficiary (to the cancellation request).")]
    NoAnswerFromCustomer = ExternalPaymentCancellationRejectionCode.NoAnswerFromCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original transaction (subject to cancellation) never received.
    /// Encoded/decoded by serializers as "NOOR".
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("_ucGJJfRYEeuLhpyIdtJzwg")]
    [Description(@"Original transaction (subject to cancellation) never received.")]
    NoOriginalTransactionReceived = ExternalPaymentCancellationRejectionCode.NoOriginalTransactionReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation request cannot be accepted because the payment instruction has been passed to the next agent.
    /// Encoded/decoded by serializers as "PTNA".
    /// </summary>
    [EnumMember(Value = "PTNA")]
    [IsoId("_ucGJKPRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation request cannot be accepted because the payment instruction has been passed to the next agent.")]
    PassedToTheNextAgent = ExternalPaymentCancellationRejectionCode.PassedToTheNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when authority is required by the Creditor to return the payment.
    /// Encoded/decoded by serializers as "RQDA".
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("_ucGJK_RYEeuLhpyIdtJzwg")]
    [Description(@"Reported when authority is required by the Creditor to return the payment.")]
    RequestingDebitAuthority = ExternalPaymentCancellationRejectionCode.RequestingDebitAuthority, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation request cannot be processed because the sequence referred to in the request is not valid.
    /// Encoded/decoded by serializers as "WSEQ".
    /// </summary>
    [EnumMember(Value = "WSEQ")]
    [IsoId("_ucP6IvRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation request cannot be processed because the sequence referred to in the request is not valid.")]
    WrongSequence = ExternalPaymentCancellationRejectionCode.WrongSequence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Complementing a Pending or Reject Status. Payment cancellation request cannot be accepted until an indemnity agreement is established.
    /// Encoded/decoded by serializers as "IDMN".
    /// </summary>
    [EnumMember(Value = "IDMN")]
    [IsoId("_w1LccQTXEey95qpfbNuEwg")]
    [Description(@"Complementing a Pending or Reject Status. Payment cancellation request cannot be accepted until an indemnity agreement is established.")]
    CancellationIndemnityRequired = ExternalPaymentCancellationRejectionCode.CancellationIndemnityRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay has already been cancelled.
    /// Encoded/decoded by serializers as "ACLR".
    /// </summary>
    [EnumMember(Value = "ACLR")]
    [IsoId("__sZkYVD_Eey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been cancelled.")]
    AlreadyCancelledRTP = ExternalPaymentCancellationRejectionCode.AlreadyCancelledRTP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay Expiry Date and Time has already passed.
    /// Encoded/decoded by serializers as "AEXR".
    /// </summary>
    [EnumMember(Value = "AEXR")]
    [IsoId("__zGpUVD_Eey6cYDbEubNXg")]
    [Description(@"Request-to-pay Expiry Date and Time has already passed.")]
    AlreadyExpiredRTP = ExternalPaymentCancellationRejectionCode.AlreadyExpiredRTP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay has already been refused by the Debtor.
    /// Encoded/decoded by serializers as "ARFR".
    /// </summary>
    [EnumMember(Value = "ARFR")]
    [IsoId("__59fQVD_Eey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been refused by the Debtor.")]
    AlreadyRefusedRTP = ExternalPaymentCancellationRejectionCode.AlreadyRefusedRTP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay has already been rejected.
    /// Encoded/decoded by serializers as "ARJR".
    /// </summary>
    [EnumMember(Value = "ARJR")]
    [IsoId("_AAqkMVEAEey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been rejected.")]
    AlreadyRejectedRTP = ExternalPaymentCancellationRejectionCode.AlreadyRejectedRTP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment related to the request-to-pay has already been transmitted for execution.
    /// Encoded/decoded by serializers as "PATE".
    /// </summary>
    [EnumMember(Value = "PATE")]
    [IsoId("_APRA4VEAEey6cYDbEubNXg")]
    [Description(@"Payment related to the request-to-pay has already been transmitted for execution.")]
    PaymentAlreadyTransmittedExecution = ExternalPaymentCancellationRejectionCode.PaymentAlreadyTransmittedExecution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as "RR04".
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_AV074VEAEey6cYDbEubNXg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalPaymentCancellationRejectionCode.RegulatoryReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for cancellation of the request-to-pay has already been rejected.
    /// Encoded/decoded by serializers as "RCAR".
    /// </summary>
    [EnumMember(Value = "RCAR")]
    [IsoId("_AlK_cVEAEey6cYDbEubNXg")]
    [Description(@"Request for cancellation of the request-to-pay has already been rejected.")]
    RfCAlreadyRejected = ExternalPaymentCancellationRejectionCode.RfCAlreadyRejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for cancellation of the request-to-pay has never been received.
    /// Encoded/decoded by serializers as "RCNR".
    /// </summary>
    [EnumMember(Value = "RCNR")]
    [IsoId("_AsUwUVEAEey6cYDbEubNXg")]
    [Description(@"Request for cancellation of the request-to-pay has never been received.")]
    RfCNeverReceived = ExternalPaymentCancellationRejectionCode.RfCNeverReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for cancellation of the request-to-pay has already been received and processed.
    /// Encoded/decoded by serializers as "RCPR".
    /// </summary>
    [EnumMember(Value = "RCPR")]
    [IsoId("_AzUwMVEAEey6cYDbEubNXg")]
    [Description(@"Request for cancellation of the request-to-pay has already been received and processed.")]
    RfCReceivedAndProcessed = ExternalPaymentCancellationRejectionCode.RfCReceivedAndProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay is unknown.
    /// Encoded/decoded by serializers as "URTP".
    /// </summary>
    [EnumMember(Value = "URTP")]
    [IsoId("_A54rMVEAEey6cYDbEubNXg")]
    [Description(@"Request-to-pay is unknown.")]
    UnknownRTP = ExternalPaymentCancellationRejectionCode.UnknownRTP, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPaymentCancellationRejection1CodeMetadataExtensions
{
    private static readonly ExternalPaymentCancellationRejection1CodeDropdownSource _dropdownSource = new ExternalPaymentCancellationRejection1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPaymentCancellationRejection1CodeDropdownRow GetMetadata(this ExternalPaymentCancellationRejection1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


