﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason45Code.  ISO2002 ID# _qjj_cFhpEeS5jeC8QHrlrg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specify the reason why the instruction cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qjj_cFhpEeS5jeC8QHrlrg")]
[Description(@"Specify the reason why the instruction cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason45Code
{
    /// <summary>
    /// Instruction received after the account servicers specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_t5pxgVhpEeS5jeC8QHrlrg")]
    [Description(@"Instruction received after the account servicers specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Instruction contains an invalid message reference, reference is unknown.
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_x231AVhpEeS5jeC8QHrlrg")]
    [Description(@"Instruction contains an invalid message reference, reference is unknown.")]
    InvalidReference,
    
    /// <summary>
    /// Other reason.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_3byPEVhpEeS5jeC8QHrlrg")]
    [Description(@"Other reason.")]
    Other,
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_6I0dEVhpEeS5jeC8QHrlrg")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_6hD98VhpEeS5jeC8QHrlrg")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress,
    
    /// <summary>
    /// The instruction is irrevocable.
    /// Encoded/decoded by serializers as "InstructionIrrevocable".
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_FhOfwVhqEeS5jeC8QHrlrg")]
    [Description(@"The instruction is irrevocable.")]
    InstructionIrrevocable,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_QyNEwVhqEeS5jeC8QHrlrg")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason45CodeMetadataExtensions
{
    private static readonly RejectionReason45CodeDropdownSource _dropdownSource = new RejectionReason45CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason45CodeDropdownRow GetMetadata(this RejectionReason45Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


