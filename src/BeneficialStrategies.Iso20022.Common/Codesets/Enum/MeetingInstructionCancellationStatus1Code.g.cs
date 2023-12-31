﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MeetingInstructionCancellationStatus1Code.  ISO2002 ID# _VpiZZdp-Ed-ak6NoX_4Aeg_-1337126365.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Status of a meeting instruction cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpiZZdp-Ed-ak6NoX_4Aeg_-1337126365")]
[Description(@"Status of a meeting instruction cancellation request.")]
[DerivedFrom(typeof(MeetingInstructionCancellationStatusCode))]
public enum MeetingInstructionCancellationStatus1Code
{
    /// <summary>
    /// Cancellation has been completed.
    /// Encoded/decoded by serializers as "CancellationCompleted".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_VpiZZtp-Ed-ak6NoX_4Aeg_-1092392896")]
    [Description(@"Cancellation has been completed.")]
    CancellationCompleted,
    
    /// <summary>
    /// Cancellation is pending. It is not known at this time whether cancellation can be executed.
    /// Encoded/decoded by serializers as "PendingCancellation".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_VpiZZ9p-Ed-ak6NoX_4Aeg_-1068378433")]
    [Description(@"Cancellation is pending. It is not known at this time whether cancellation can be executed.")]
    PendingCancellation,
    
    /// <summary>
    /// Cancellation will not be executed due to business reasons.
    /// Encoded/decoded by serializers as "CancellationDenied".
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_VpiZaNp-Ed-ak6NoX_4Aeg_-1051757850")]
    [Description(@"Cancellation will not be executed due to business reasons.")]
    CancellationDenied,
    
    /// <summary>
    /// Cancellation request has been rejected for further processing due to system (data) reasons.
    /// Encoded/decoded by serializers as "CancellationRejected".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_VpsKYNp-Ed-ak6NoX_4Aeg_-1009275976")]
    [Description(@"Cancellation request has been rejected for further processing due to system (data) reasons.")]
    CancellationRejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MeetingInstructionCancellationStatus1CodeMetadataExtensions
{
    private static readonly MeetingInstructionCancellationStatus1CodeDropdownSource _dropdownSource = new MeetingInstructionCancellationStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMeetingInstructionCancellationStatus1CodeDropdownRow GetMetadata(this MeetingInstructionCancellationStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


