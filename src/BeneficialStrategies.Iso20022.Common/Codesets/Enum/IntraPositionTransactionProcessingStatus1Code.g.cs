﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IntraPositionTransactionProcessingStatus1Code.  ISO2002 ID# _aa3aYtp-Ed-ak6NoX_4Aeg_-836406022.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aa3aYtp-Ed-ak6NoX_4Aeg_-836406022")]
[Description(@"Provides the processing status of a transaction (at account servicer level).")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum IntraPositionTransactionProcessingStatus1Code
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_aa3aY9p-Ed-ak6NoX_4Aeg_-836405991")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled,
    
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as "AcknowledgedAccepted".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aa3aZNp-Ed-ak6NoX_4Aeg_-836405652")]
    [Description(@"Instruction has been acknowledged/accepted for further processing by the account servicer.")]
    AcknowledgedAccepted,
    
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_aa3aZdp-Ed-ak6NoX_4Aeg_-836405651")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected,
    
    /// <summary>
    /// Instruction is accepted but in repair.
    /// Encoded/decoded by serializers as "InRepair".
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_aa3aZtp-Ed-ak6NoX_4Aeg_-836405621")]
    [Description(@"Instruction is accepted but in repair.")]
    InRepair,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IntraPositionTransactionProcessingStatus1CodeMetadataExtensions
{
    private static readonly IntraPositionTransactionProcessingStatus1CodeDropdownSource _dropdownSource = new IntraPositionTransactionProcessingStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIntraPositionTransactionProcessingStatus1CodeDropdownRow GetMetadata(this IntraPositionTransactionProcessingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


