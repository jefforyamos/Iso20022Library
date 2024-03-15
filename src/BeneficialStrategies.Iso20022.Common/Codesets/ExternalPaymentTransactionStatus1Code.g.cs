﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPaymentTransactionStatus1Code.  ISO2002 ID# _wCGbwZRjEeazAtAtDSg0Nw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an individual payment instructions, as published in an external payment transaction status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wCGbwZRjEeazAtAtDSg0Nw")]
[Description(@"Specifies the status of an individual payment instructions, as published in an external payment transaction status code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPaymentTransactionStatusCode))]
public enum ExternalPaymentTransactionStatus1Code
{
    /// <summary>
    /// Settlement on the creditor&apos;s account has been completed.
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_uV_hK_RYEeuLhpyIdtJzwg")]
    [Description(@"Settlement on the creditor's account has been completed.")]
    AcceptedSettlementCompletedCreditorAccount = ExternalPaymentTransactionStatusCode.AcceptedSettlementCompletedCreditorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_uWIrEvRYEeuLhpyIdtJzwg")]
    [Description(@"Preceding check of technical validation was successful. Customer profile check was also successful.")]
    AcceptedCustomerProfile = ExternalPaymentTransactionStatusCode.AcceptedCustomerProfile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preceding check of technical validation and customer profile was successful and an automatic funds check was positive.
    /// Encoded/decoded by serializers as &quot;ACFC&quot;.
    /// </summary>
    [EnumMember(Value = "ACFC")]
    [IsoId("_uWIrFfRYEeuLhpyIdtJzwg")]
    [Description(@"Preceding check of technical validation and customer profile was successful and an automatic funds check was positive.")]
    AcceptedFundsChecked = ExternalPaymentTransactionStatusCode.AcceptedFundsChecked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instruction to issue a cheque has been accepted, and the cheque has been issued but not yet been deposited or cleared.
    /// Encoded/decoded by serializers as &quot;ACIS&quot;.
    /// </summary>
    [EnumMember(Value = "ACIS")]
    [IsoId("_uWIrGPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction to issue a cheque has been accepted, and the cheque has been issued but not yet been deposited or cleared.")]
    AcceptedandChequeIssued = ExternalPaymentTransactionStatusCode.AcceptedandChequeIssued, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement completed.|Usage : this can be used by a Market Infrastructure reporting to Infrastructure Participant or an Account Servicer to Account Owner to report that the transaction account entry has been completed.|Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement|
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_uWIrG_RYEeuLhpyIdtJzwg")]
    [Description(@"Settlement completed.|Usage : this can be used by a Market Infrastructure reporting to Infrastructure Participant or an Account Servicer to Account Owner to report that the transaction account entry has been completed.|Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement|")]
    AcceptedSettlementCompletedDebitorAccount = ExternalPaymentTransactionStatusCode.AcceptedSettlementCompletedDebitorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment instruction has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_uWIrHvRYEeuLhpyIdtJzwg")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment instruction has been accepted for execution.")]
    AcceptedSettlementInProcess = ExternalPaymentTransactionStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication and syntactical and semantical validation are successful
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_uWScEvRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication and syntactical and semantical validation are successful")]
    AcceptedTechnicalValidation = ExternalPaymentTransactionStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_uWScFfRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction is accepted but a change will be made, such as date or remittance not sent.")]
    AcceptedWithChange = ExternalPaymentTransactionStatusCode.AcceptedWithChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instruction included in the credit transfer is accepted without being posted to the creditor customer’s account.
    /// Encoded/decoded by serializers as &quot;ACWP&quot;.
    /// </summary>
    [EnumMember(Value = "ACWP")]
    [IsoId("_uWcNEvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction included in the credit transfer is accepted without being posted to the creditor customer’s account.")]
    AcceptedWithoutPosting = ExternalPaymentTransactionStatusCode.AcceptedWithoutPosting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment transaction previously reported with status &apos;ACWP&apos; is blocked, for example, funds will neither be posted to the Creditor&apos;s account, nor be returned to the Debtor.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_uWcNFfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment transaction previously reported with status 'ACWP' is blocked, for example, funds will neither be posted to the Creditor's account, nor be returned to the Debtor.")]
    Blocked = ExternalPaymentTransactionStatusCode.Blocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment initiation has been successfully cancelled after having received a request for cancellation.|Usage: code to be used in the context of APIs only.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_uWcNGPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment initiation has been successfully cancelled after having received a request for cancellation.|Usage: code to be used in the context of APIs only.")]
    Cancelled = ExternalPaymentTransactionStatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash has been picked up by the Creditor.
    /// Encoded/decoded by serializers as &quot;CPUC&quot;.
    /// </summary>
    [EnumMember(Value = "CPUC")]
    [IsoId("_uWcNG_RYEeuLhpyIdtJzwg")]
    [Description(@"Cash has been picked up by the Creditor.")]
    CashPickedUpByCreditor = ExternalPaymentTransactionStatusCode.CashPickedUpByCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment initiation needs multiple authentications, where some but not yet all have been performed. Syntactical and semantical validations are successful.
    /// Encoded/decoded by serializers as &quot;PATC&quot;.
    /// </summary>
    [EnumMember(Value = "PATC")]
    [IsoId("_uWlXAvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment initiation needs multiple authentications, where some but not yet all have been performed. Syntactical and semantical validations are successful.")]
    PartiallyAcceptedTechnicalCorrect = ExternalPaymentTransactionStatusCode.PartiallyAcceptedTechnicalCorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instruction is pending. Further checks and status update will be performed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_uWlXBfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction is pending. Further checks and status update will be performed.")]
    Pending = ExternalPaymentTransactionStatusCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for Payment has been presented to the Debtor.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_uWvIAvRYEeuLhpyIdtJzwg")]
    [Description(@"Request for Payment has been presented to the Debtor.")]
    Presented = ExternalPaymentTransactionStatusCode.Presented, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instruction has been received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_uWvIBfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction has been received.")]
    Received = ExternalPaymentTransactionStatusCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_uW4R8vRYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction has been rejected.")]
    Rejected = ExternalPaymentTransactionStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of transaction released from the Debtor Agent and accepted by the clearing.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_aXLdIeGIEeyiZZWde7CbVw")]
    [Description(@"Status of transaction released from the Debtor Agent and accepted by the clearing.")]
    AcceptedClearingProcessed = ExternalPaymentTransactionStatusCode.AcceptedClearingProcessed, // same ordinal as derivation source for type conversions
    
}
