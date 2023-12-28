﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionProcessingStatus1Code.  ISO2002 ID# _YsAE2Np-Ed-ak6NoX_4Aeg_-482977155.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YsAE2Np-Ed-ak6NoX_4Aeg_-482977155")]
[Description(@"Provides the processing status of a transaction (at account servicer level).")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum TransactionProcessingStatus1Code
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_YsAE2dp-Ed-ak6NoX_4Aeg_-108953148")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled,
    
    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// Encoded/decoded by serializers as "PendingCancellation".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_YsJOwNp-Ed-ak6NoX_4Aeg_18493372")]
    [Description(@"Cancellation request from yourself for this instruction is pending waiting for further processing.")]
    PendingCancellation,
    
    /// <summary>
    /// Cancellation request from the counterparty is awaiting for your cancellation request or your consent.
    /// Encoded/decoded by serializers as "CancellationRequested".
    /// </summary>
    [EnumMember(Value = "CPRC")]
    [IsoId("_YsJOwdp-Ed-ak6NoX_4Aeg_-1206295875")]
    [Description(@"Cancellation request from the counterparty is awaiting for your cancellation request or your consent.")]
    CancellationRequested,
    
    /// <summary>
    /// Processing of the instruction is pending.
    /// Encoded/decoded by serializers as "PendingProcessing".
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_YsJOwtp-Ed-ak6NoX_4Aeg_-1063150046")]
    [Description(@"Processing of the instruction is pending.")]
    PendingProcessing,
    
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as "AcknowledgedAccepted".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_YsJOw9p-Ed-ak6NoX_4Aeg_-676197587")]
    [Description(@"Instruction has been acknowledged/accepted for further processing by the account servicer.")]
    AcknowledgedAccepted,
    
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_YsJOxNp-Ed-ak6NoX_4Aeg_-629098663")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected,
    
    /// <summary>
    /// Instruction is accepted but in repair.
    /// Encoded/decoded by serializers as "InRepair".
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_YsJOxdp-Ed-ak6NoX_4Aeg_26008587")]
    [Description(@"Instruction is accepted but in repair.")]
    InRepair,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionProcessingStatus1CodeMetadataExtensions
{
    private static readonly TransactionProcessingStatus1CodeDropdownSource _dropdownSource = new TransactionProcessingStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionProcessingStatus1CodeDropdownRow GetMetadata(this TransactionProcessingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


