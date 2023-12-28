﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationReasonCode.  ISO2002 ID# _bYaAsdp-Ed-ak6NoX_4Aeg_-51113838.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for requesting the cancellation of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYaAsdp-Ed-ak6NoX_4Aeg_-51113838")]
[Description(@"Specifies the reason for requesting the cancellation of a payment instruction.")]
public enum CancellationReasonCode
{
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as "DUPL".
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bYaAstp-Ed-ak6NoX_4Aeg_870293849")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment,
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as "AGNT".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_bYaAs9p-Ed-ak6NoX_4Aeg_870294322")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent,
    
    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as "CURR".
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_bYaAtNp-Ed-ak6NoX_4Aeg_870294347")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency,
    
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bYaAtdp-Ed-ak6NoX_4Aeg_870294364")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer,
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as "UPAY".
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_bYaAttp-Ed-ak6NoX_4Aeg_870294382")]
    [Description(@"Payment is not justified.")]
    UnduePayment,
    
    /// <summary>
    /// Payment is a suspicious payment.
    /// Encoded/decoded by serializers as "SUSP".
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_bYaAt9p-Ed-ak6NoX_4Aeg_881376013")]
    [Description(@"Payment is a suspicious payment.")]
    SuspiciousPayment,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as "MM23".
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_bYaAuNp-Ed-ak6NoX_4Aeg_-1860763140")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as "MM24".
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_bYjKoNp-Ed-ak6NoX_4Aeg_-1731468970")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails,
    
    /// <summary>
    /// Cancellation requested because an investigation request has been received and no remediation is possible.
    /// Encoded/decoded by serializers as "CUTA".
    /// </summary>
    [EnumMember(Value = "CUTA")]
    [IsoId("_bYjKodp-Ed-ak6NoX_4Aeg_1014049617")]
    [Description(@"Cancellation requested because an investigation request has been received and no remediation is possible.")]
    CancelUponUnableToApply,
    
    /// <summary>
    /// Cancellation requested following technical problems resulting in an erroneous transaction.
    /// Encoded/decoded by serializers as "TECH".
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_t9NxNFkyEeGeoaLUQk__nA_-772063853")]
    [Description(@"Cancellation requested following technical problems resulting in an erroneous transaction.")]
    TechnicalProblem,
    
    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as "FRAD".
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_t9XiMFkyEeGeoaLUQk__nA_34147394")]
    [Description(@"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.")]
    FraudulentOrigin,
    
    /// <summary>
    /// Cover payment has been cancelled or returned.
    /// Encoded/decoded by serializers as "COVR".
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_rCYTIByoEeispO42NVVLrw")]
    [Description(@"Cover payment has been cancelled or returned.")]
    CoverCancelledOrReturned,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationReasonCodeMetadataExtensions
{
    private static readonly CancellationReasonCodeDropdownSource _dropdownSource = new CancellationReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationReasonCodeDropdownRow GetMetadata(this CancellationReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


