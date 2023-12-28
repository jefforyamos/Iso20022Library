﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCancellationReason1Code.  ISO2002 ID# _8DT3MUgtEeaGKYpLDboHPQ.
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
[IsoId("_8DT3MUgtEeaGKYpLDboHPQ")]
[Description(@"Specifies the cancellation reason, as published in an external cancellation reason code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalCancellationReasonCode))]
public enum ExternalCancellationReason1Code
{
    /// <summary>
    /// Wrong account number in Credit Transfer.
    /// Encoded/decoded by serializers as "InvalidCreditorAccountNumber".
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_uXeu5fRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong account number in Credit Transfer.")]
    InvalidCreditorAccountNumber,
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as "IncorrectAgent".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_uXof4vRYEeuLhpyIdtJzwg")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent,
    
    /// <summary>
    /// Amount is not the amount agreed or expected.
    /// Encoded/decoded by serializers as "WrongAmount".
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_uXof5fRYEeuLhpyIdtJzwg")]
    [Description(@"Amount is not the amount agreed or expected.")]
    WrongAmount,
    
    /// <summary>
    /// Debtor or Ultimate Debtor identification code missing or invalid.
    /// Encoded/decoded by serializers as "InvalidDebtorIdentificationCode".
    /// </summary>
    [EnumMember(Value = "BE16")]
    [IsoId("_uXyQ4vRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor or Ultimate Debtor identification code missing or invalid.")]
    InvalidDebtorIdentificationCode,
    
    /// <summary>
    /// Cover payments has either been returned or cancelled.
    /// Encoded/decoded by serializers as "CoverCancelledOrReturned".
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_uXyQ5fRYEeuLhpyIdtJzwg")]
    [Description(@"Cover payments has either been returned or cancelled.")]
    CoverCancelledOrReturned,
    
    /// <summary>
    /// Currency of the payment is incorrect.|
    /// Encoded/decoded by serializers as "IncorrectCurrency".
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_uXyQ6PRYEeuLhpyIdtJzwg")]
    [Description(@"Currency of the payment is incorrect.|")]
    IncorrectCurrency,
    
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as "RequestedByCustomer".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_uX7a0vRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer,
    
    /// <summary>
    /// Cancellation requested because an investigation request has been received and no remediation is possible.
    /// Encoded/decoded by serializers as "CancelUponUnableToApply".
    /// </summary>
    [EnumMember(Value = "CUTA")]
    [IsoId("_uX7a1fRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested because an investigation request has been received and no remediation is possible.")]
    CancelUponUnableToApply,
    
    /// <summary>
    /// Cancellation requested because the original payment order expired due to time-out.
    /// Encoded/decoded by serializers as "TimeOut".
    /// </summary>
    [EnumMember(Value = "DS24")]
    [IsoId("_uYFL0vRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested because the original payment order expired due to time-out.")]
    TimeOut,
    
    /// <summary>
    /// Invalid date (for example, wrong or missing settlement date).
    /// Encoded/decoded by serializers as "InvalidDate".
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_uYFL1fRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid date (for example, wrong or missing settlement date).")]
    InvalidDate,
    
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as "DuplicatePayment".
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_uYFL2PRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment,
    
    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as "FraudulentOrigin".
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_uYOVwvRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.")]
    FraudulentOrigin,
    
    /// <summary>
    /// To complement a rejection response, suggesting the request for cancelation should be forwarded to the next agent in the payment transaction chain.
    /// Encoded/decoded by serializers as "ForwardToNextAgent".
    /// </summary>
    [EnumMember(Value = "FRNA")]
    [IsoId("_uYOVxfRYEeuLhpyIdtJzwg")]
    [Description(@"To complement a rejection response, suggesting the request for cancelation should be forwarded to the next agent in the payment transaction chain.")]
    ForwardToNextAgent,
    
    /// <summary>
    /// Direct Debit Tracking recalled as Mandate Cancelled 
    /// Encoded/decoded by serializers as "FinalResponse".
    /// </summary>
    [EnumMember(Value = "FRTR")]
    [IsoId("_uYOVyPRYEeuLhpyIdtJzwg")]
    [Description(@"Direct Debit Tracking recalled as Mandate Cancelled ")]
    FinalResponse,
    
    /// <summary>
    /// To express the wish to establish a bilateral indemnity agreement.
    /// Encoded/decoded by serializers as "IndemnityRequired".
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_uYOVy_RYEeuLhpyIdtJzwg")]
    [Description(@"To express the wish to establish a bilateral indemnity agreement.")]
    IndemnityRequired,
    
    /// <summary>
    /// The underlying transaction in relation to an RTP was modified.
    /// Encoded/decoded by serializers as "ModifiedTransaction".
    /// </summary>
    [EnumMember(Value = "MODT")]
    [IsoId("_uYOVzvRYEeuLhpyIdtJzwg")]
    [Description(@"The underlying transaction in relation to an RTP was modified.")]
    ModifiedTransaction,
    
    /// <summary>
    /// The underlying transaction in relation to an RTP was already paid (via other means).
    /// Encoded/decoded by serializers as "TransactionAlreadyPaid".
    /// </summary>
    [EnumMember(Value = "PAID")]
    [IsoId("_uYYGwvRYEeuLhpyIdtJzwg")]
    [Description(@"The underlying transaction in relation to an RTP was already paid (via other means).")]
    TransactionAlreadyPaid,
    
    /// <summary>
    /// The payment is cancelled since a cash amount rendered was not correct or goods or a service was not rendered to the customer, e.g. in an e-commerce situation.
    /// Encoded/decoded by serializers as "ServiceNotRendered".
    /// </summary>
    [EnumMember(Value = "SVNR")]
    [IsoId("_uYYGxfRYEeuLhpyIdtJzwg")]
    [Description(@"The payment is cancelled since a cash amount rendered was not correct or goods or a service was not rendered to the customer, e.g. in an e-commerce situation.")]
    ServiceNotRendered,
    
    /// <summary>
    /// Cancellation requested by System Member to Settlement System Administrator to indicate that the cancellation request must not be forwarded further in the chain.
    /// Encoded/decoded by serializers as "RequestToSettlementSystemAdministrator".
    /// </summary>
    [EnumMember(Value = "SYAD")]
    [IsoId("_uYh3wvRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested by System Member to Settlement System Administrator to indicate that the cancellation request must not be forwarded further in the chain.")]
    RequestToSettlementSystemAdministrator,
    
    /// <summary>
    /// Cancellation requested following technical problems resulting in an erroneous transaction.
    /// Encoded/decoded by serializers as "TechnicalProblem".
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_uYh3xfRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested following technical problems resulting in an erroneous transaction.")]
    TechnicalProblem,
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as "UnduePayment".
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_uYrBsvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is not justified.")]
    UnduePayment,
    
    /// <summary>
    /// Cancellation or request for return requested by the Debtor specifically due to one or more errors by debtor in the original Credit Transfer. Usage: This code can be used for any error in the original Credit Transfer made by the Debtor. Can also be used if multiple errors were made in the original Credit Transfer.
    /// Encoded/decoded by serializers as "EndUserError".
    /// </summary>
    [EnumMember(Value = "ENUE")]
    [IsoId("_qvBlgQQyEey95qpfbNuEwg")]
    [Description(@"Cancellation or request for return requested by the Debtor specifically due to one or more errors by debtor in the original Credit Transfer. Usage: This code can be used for any error in the original Credit Transfer made by the Debtor. Can also be used if multiple errors were made in the original Credit Transfer.")]
    EndUserError,
    
    /// <summary>
    /// The Debtor is requesting a return of the payment because the payment was not properly authorized.
    /// Usage: This code can be used in the case where a Credit Transfer was made without proper authorization from the Debtor. This could be due to compromised end user credentials.
    /// Encoded/decoded by serializers as "UnauthorizedPayment".
    /// </summary>
    [EnumMember(Value = "UAPA")]
    [IsoId("_q-OfIQQyEey95qpfbNuEwg")]
    [Description(@"The Debtor is requesting a return of the payment because the payment was not properly authorized. Usage: This code can be used in the case where a Credit Transfer was made without proper authorization from the Debtor. This could be due to compromised end user credentials.")]
    UnauthorizedPayment,
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as "Narrative".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_l3VBUQQzEey95qpfbNuEwg")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    Narrative,
    
    /// <summary>
    /// Debtor account number invalid or missing.
    /// Encoded/decoded by serializers as "InvalidDebtorAccountNumber".
    /// </summary>
    [EnumMember(Value = "AC02")]
    [IsoId("_pPR0kQQzEey95qpfbNuEwg")]
    [Description(@"Debtor account number invalid or missing.")]
    InvalidDebtorAccountNumber,
    
    /// <summary>
    /// Process a cancellation request but batch already settled.
    /// Encoded/decoded by serializers as "BatchInstructionAlreadySettled".
    /// </summary>
    [EnumMember(Value = "BIAS")]
    [IsoId("_6KrlgQTSEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request but batch already settled.")]
    BatchInstructionAlreadySettled,
    
    /// <summary>
    /// Process a cancellation request with incorrect reference to original batch.
    /// Encoded/decoded by serializers as "InvalidCancellationRequest".
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_6mjCIQTSEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request with incorrect reference to original batch.")]
    InvalidCancellationRequest,
    
    /// <summary>
    /// Duplication of a request-to-pay message.
    /// Encoded/decoded by serializers as "DuplicationRequestToPay".
    /// </summary>
    [EnumMember(Value = "DRTP")]
    [IsoId("_Umy2gVEHEey6cYDbEubNXg")]
    [Description(@"Duplication of a request-to-pay message.")]
    DuplicationRequestToPay,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalCancellationReason1CodeMetadataExtensions
{
    private static readonly ExternalCancellationReason1CodeDropdownSource _dropdownSource = new ExternalCancellationReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalCancellationReason1CodeDropdownRow GetMetadata(this ExternalCancellationReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


