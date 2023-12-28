﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentStatusReason2Code.  ISO2002 ID# _iL_l8KXaEeaBtJ1HvhzRtg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the reason for a payment status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iL_l8KXaEeaBtJ1HvhzRtg")]
[Description(@"Provides the reason for a payment status.")]
[DerivedFrom(typeof(ExternalPaymentStatusReasonCode))]
public enum PaymentStatusReason2Code
{
    /// <summary>
    /// The transaction processing cannot be completed the same day.
    /// Encoded/decoded by serializers as "CreditDebitNotConfirmed".
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_m3wxgaXaEeaBtJ1HvhzRtg")]
    [Description(@"The transaction processing cannot be completed the same day.")]
    CreditDebitNotConfirmed,
    
    /// <summary>
    /// Credit to the creditor's account is pending as status Originator is waiting for funds provided via a cover.
    /// Encoded/decoded by serializers as "CreditPendingFunds".
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_m8ReEaXaEeaBtJ1HvhzRtg")]
    [Description(@"Credit to the creditor's account is pending as status Originator is waiting for funds provided via a cover.")]
    CreditPendingFunds,
    
    /// <summary>
    /// The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure maintaining the transaction’s service obligations.
    /// Encoded/decoded by serializers as "PaymentTransferredAndSLAMaintained".
    /// </summary>
    [EnumMember(Value = "G000")]
    [IsoId("_nGkpkaXaEeaBtJ1HvhzRtg")]
    [Description(@"The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure maintaining the transaction’s service obligations.")]
    PaymentTransferredAndSLAMaintained,
    
    /// <summary>
    /// The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure where the transaction’s service obligations may no longer be guaranteed.
    /// Encoded/decoded by serializers as "PaymentTransferredAndSLANoLongerMaintained".
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_nLJnkaXaEeaBtJ1HvhzRtg")]
    [Description(@"The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure where the transaction’s service obligations may no longer be guaranteed.")]
    PaymentTransferredAndSLANoLongerMaintained,
    
    /// <summary>
    /// In an FI to FI Customer Credit Transfer: Credit to creditor's account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation.
    /// Encoded/decoded by serializers as "CreditPendingDocuments".
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_eqFg0aZbEeatnf2letP_og")]
    [Description(@"In an FI to FI Customer Credit Transfer: Credit to creditor's account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation.")]
    CreditPendingDocuments,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentStatusReason2CodeMetadataExtensions
{
    private static readonly PaymentStatusReason2CodeDropdownSource _dropdownSource = new PaymentStatusReason2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentStatusReason2CodeDropdownRow GetMetadata(this PaymentStatusReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


