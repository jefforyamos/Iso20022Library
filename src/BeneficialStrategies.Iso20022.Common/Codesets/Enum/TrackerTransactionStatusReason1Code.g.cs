﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TrackerTransactionStatusReason1Code.  ISO2002 ID# _8QHecPpQEemXaqBx8S4XSg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the reason for a status of a payment transaction in the tracker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8QHecPpQEemXaqBx8S4XSg")]
[Description(@"Provides the reason for a status of a payment transaction in the tracker.")]
[DerivedFrom(typeof(TrackerTransactionStatusReasonCode))]
public enum TrackerTransactionStatusReason1Code
{
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator.
    /// In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as "CreditDebitNotConfirmed".
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_3Ofz4fruEemIKt9hrQ9pJw")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator. In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator.")]
    CreditDebitNotConfirmed,
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator.
    /// In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as "CreditPendingDocuments".
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_3Sb4sfruEemIKt9hrQ9pJw")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator. In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator.")]
    CreditPendingDocuments,
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as "CreditPendingFunds".
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_3ZrwMfruEemIKt9hrQ9pJw")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.")]
    CreditPendingFunds,
    
    /// <summary>
    /// In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.
    /// 
    /// In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.
    /// Encoded/decoded by serializers as "PaymentTransferredAndNotTracked".
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_30nYsfruEemIKt9hrQ9pJw")]
    [Description(@"In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.  In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.")]
    PaymentTransferredAndNotTracked,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TrackerTransactionStatusReason1CodeMetadataExtensions
{
    private static readonly TrackerTransactionStatusReason1CodeDropdownSource _dropdownSource = new TrackerTransactionStatusReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITrackerTransactionStatusReason1CodeDropdownRow GetMetadata(this TrackerTransactionStatusReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


