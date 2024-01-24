﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCancellationReasonCode.  ISO2002 ID# _6EBKgJF4EeeMPMycDdDCGw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cancellation reason, as published in an external cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6EBKgJF4EeeMPMycDdDCGw")]
[Description(@"Specifies the cancellation reason, as published in an external cancellation reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalCancellationReason1Code))]
public enum ExternalCancellationReasonCode
{
    /// <summary>
    /// Debtor account number invalid or missing.
    /// Encoded/decoded by serializers as "AC02".
    /// </summary>
    [EnumMember(Value = "AC02")]
    [IsoId("_uXeu4PRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account number invalid or missing.")]
    InvalidDebtorAccountNumber,
    
    /// <summary>
    /// Wrong account number in Credit Transfer.
    /// Encoded/decoded by serializers as "AC03".
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_uXeu4_RYEeuLhpyIdtJzwg")]
    [Description(@"Wrong account number in Credit Transfer.")]
    InvalidCreditorAccountNumber,
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as "AGNT".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_uXof4PRYEeuLhpyIdtJzwg")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent,
    
    /// <summary>
    /// Amount is not the amount agreed or expected.
    /// Encoded/decoded by serializers as "AM09".
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_uXof4_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount is not the amount agreed or expected.")]
    WrongAmount,
    
    /// <summary>
    /// Debtor or Ultimate Debtor identification code missing or invalid.
    /// Encoded/decoded by serializers as "BE16".
    /// </summary>
    [EnumMember(Value = "BE16")]
    [IsoId("_uXyQ4PRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor or Ultimate Debtor identification code missing or invalid.")]
    InvalidDebtorIdentificationCode,
    
    /// <summary>
    /// Cover payments has either been returned or cancelled.
    /// Encoded/decoded by serializers as "COVR".
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_uXyQ4_RYEeuLhpyIdtJzwg")]
    [Description(@"Cover payments has either been returned or cancelled.")]
    CoverCancelledOrReturned,
    
    /// <summary>
    /// Currency of the payment is incorrect.|
    /// Encoded/decoded by serializers as "CURR".
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_uXyQ5vRYEeuLhpyIdtJzwg")]
    [Description(@"Currency of the payment is incorrect.|")]
    IncorrectCurrency,
    
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_uX7a0PRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer,
    
    /// <summary>
    /// Cancellation requested because an investigation request has been received and no remediation is possible.
    /// Encoded/decoded by serializers as "CUTA".
    /// </summary>
    [EnumMember(Value = "CUTA")]
    [IsoId("_uX7a0_RYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested because an investigation request has been received and no remediation is possible.")]
    CancelUponUnableToApply,
    
    /// <summary>
    /// Cancellation requested because the original payment order expired due to time-out.
    /// Encoded/decoded by serializers as "DS24".
    /// </summary>
    [EnumMember(Value = "DS24")]
    [IsoId("_uYFL0PRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested because the original payment order expired due to time-out.")]
    TimeOut,
    
    /// <summary>
    /// Invalid date (for example, wrong or missing settlement date).
    /// Encoded/decoded by serializers as "DT01".
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_uYFL0_RYEeuLhpyIdtJzwg")]
    [Description(@"Invalid date (for example, wrong or missing settlement date).")]
    InvalidDate,
    
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as "DUPL".
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_uYFL1vRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment,
    
    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as "FRAD".
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_uYOVwPRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.")]
    FraudulentOrigin,
    
    /// <summary>
    /// To complement a rejection response, suggesting the request for cancelation should be forwarded to the next agent in the payment transaction chain.
    /// Encoded/decoded by serializers as "FRNA".
    /// </summary>
    [EnumMember(Value = "FRNA")]
    [IsoId("_uYOVw_RYEeuLhpyIdtJzwg")]
    [Description(@"To complement a rejection response, suggesting the request for cancelation should be forwarded to the next agent in the payment transaction chain.")]
    ForwardToNextAgent,
    
    /// <summary>
    /// Direct Debit Tracking recalled as Mandate Cancelled 
    /// Encoded/decoded by serializers as "FRTR".
    /// </summary>
    [EnumMember(Value = "FRTR")]
    [IsoId("_uYOVxvRYEeuLhpyIdtJzwg")]
    [Description(@"Direct Debit Tracking recalled as Mandate Cancelled ")]
    FinalResponse,
    
    /// <summary>
    /// To express the wish to establish a bilateral indemnity agreement.
    /// Encoded/decoded by serializers as "INDM".
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_uYOVyfRYEeuLhpyIdtJzwg")]
    [Description(@"To express the wish to establish a bilateral indemnity agreement.")]
    IndemnityRequired,
    
    /// <summary>
    /// The underlying transaction in relation to an RTP was modified.
    /// Encoded/decoded by serializers as "MODT".
    /// </summary>
    [EnumMember(Value = "MODT")]
    [IsoId("_uYOVzPRYEeuLhpyIdtJzwg")]
    [Description(@"The underlying transaction in relation to an RTP was modified.")]
    ModifiedTransaction,
    
    /// <summary>
    /// The underlying transaction in relation to an RTP was already paid (via other means).
    /// Encoded/decoded by serializers as "PAID".
    /// </summary>
    [EnumMember(Value = "PAID")]
    [IsoId("_uYYGwPRYEeuLhpyIdtJzwg")]
    [Description(@"The underlying transaction in relation to an RTP was already paid (via other means).")]
    TransactionAlreadyPaid,
    
    /// <summary>
    /// The payment is cancelled since a cash amount rendered was not correct or goods or a service was not rendered to the customer, e.g. in an e-commerce situation.
    /// Encoded/decoded by serializers as "SVNR".
    /// </summary>
    [EnumMember(Value = "SVNR")]
    [IsoId("_uYYGw_RYEeuLhpyIdtJzwg")]
    [Description(@"The payment is cancelled since a cash amount rendered was not correct or goods or a service was not rendered to the customer, e.g. in an e-commerce situation.")]
    ServiceNotRendered,
    
    /// <summary>
    /// Cancellation requested by System Member to Settlement System Administrator to indicate that the cancellation request must not be forwarded further in the chain.
    /// Encoded/decoded by serializers as "SYAD".
    /// </summary>
    [EnumMember(Value = "SYAD")]
    [IsoId("_uYh3wPRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested by System Member to Settlement System Administrator to indicate that the cancellation request must not be forwarded further in the chain.")]
    RequestToSettlementSystemAdministrator,
    
    /// <summary>
    /// Cancellation requested following technical problems resulting in an erroneous transaction.
    /// Encoded/decoded by serializers as "TECH".
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_uYh3w_RYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested following technical problems resulting in an erroneous transaction.")]
    TechnicalProblem,
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as "UPAY".
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_uYrBsPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is not justified.")]
    UnduePayment,
    
    /// <summary>
    /// Cancellation or request for return requested by the Debtor specifically due to one or more errors by debtor in the original Credit Transfer. Usage: This code can be used for any error in the original Credit Transfer made by the Debtor. Can also be used if multiple errors were made in the original Credit Transfer.
    /// Encoded/decoded by serializers as "ENUE".
    /// </summary>
    [EnumMember(Value = "ENUE")]
    [IsoId("_W8ICwAQyEey95qpfbNuEwg")]
    [Description(@"Cancellation or request for return requested by the Debtor specifically due to one or more errors by debtor in the original Credit Transfer. Usage: This code can be used for any error in the original Credit Transfer made by the Debtor. Can also be used if multiple errors were made in the original Credit Transfer.")]
    EndUserError,
    
    /// <summary>
    /// The Debtor is requesting a return of the payment because the payment was not properly authorized.
    /// Usage: This code can be used in the case where a Credit Transfer was made without proper authorization from the Debtor. This could be due to compromised end user credentials.
    /// Encoded/decoded by serializers as "UAPA".
    /// </summary>
    [EnumMember(Value = "UAPA")]
    [IsoId("_iHFfUAQyEey95qpfbNuEwg")]
    [Description(@"The Debtor is requesting a return of the payment because the payment was not properly authorized.|Usage: This code can be used in the case where a Credit Transfer was made without proper authorization from the Debtor. This could be due to compromised end user credentials.")]
    UnauthorizedPayment,
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as "NARR".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_eCWpIAQzEey95qpfbNuEwg")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    Narrative,
    
    /// <summary>
    /// Process a cancellation request with incorrect reference to original batch.
    /// Encoded/decoded by serializers as "INCR".
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_cCBI0ATSEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request with incorrect reference to original batch.")]
    InvalidCancellationRequest,
    
    /// <summary>
    /// Process a cancellation request but batch already settled.
    /// Encoded/decoded by serializers as "BIAS".
    /// </summary>
    [EnumMember(Value = "BIAS")]
    [IsoId("_pF09YATSEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request but batch already settled.")]
    BatchInstructionAlreadySettled,
    
    /// <summary>
    /// Duplication of a request-to-pay message.
    /// Encoded/decoded by serializers as "DRTP".
    /// </summary>
    [EnumMember(Value = "DRTP")]
    [IsoId("_8Uvn4FEGEey6cYDbEubNXg")]
    [Description(@"Duplication of a request-to-pay message.")]
    DuplicationRequestToPay,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalCancellationReasonCodeMetadataExtensions
{
    private static readonly ExternalCancellationReasonCodeDropdownSource _dropdownSource = new ExternalCancellationReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalCancellationReasonCodeDropdownRow GetMetadata(this ExternalCancellationReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


