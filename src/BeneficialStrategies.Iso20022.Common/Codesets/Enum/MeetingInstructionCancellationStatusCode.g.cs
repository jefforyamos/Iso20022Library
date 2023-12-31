﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MeetingInstructionCancellationStatusCode.  ISO2002 ID# _VpiZYNp-Ed-ak6NoX_4Aeg_-1662861442.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Status of a meeting instruction cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpiZYNp-Ed-ak6NoX_4Aeg_-1662861442")]
[Description(@"Status of a meeting instruction cancellation request.")]
[Derivations(typeof(MeetingInstructionCancellationStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum MeetingInstructionCancellationStatusCode
{
    /// <summary>
    /// Cancellation has been completed.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_VpiZYdp-Ed-ak6NoX_4Aeg_1796054566")]
    [Description(@"Cancellation has been completed.")]
    CancellationCompleted,
    
    /// <summary>
    /// Cancellation is pending. It is not known at this time whether cancellation can be executed.
    /// Encoded/decoded by serializers as "CANP".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_VpiZYtp-Ed-ak6NoX_4Aeg_2029705192")]
    [Description(@"Cancellation is pending. It is not known at this time whether cancellation can be executed.")]
    PendingCancellation,
    
    /// <summary>
    /// Cancellation will not be executed due to business reasons.
    /// Encoded/decoded by serializers as "DEND".
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_VpiZY9p-Ed-ak6NoX_4Aeg_-1981741169")]
    [Description(@"Cancellation will not be executed due to business reasons.")]
    CancellationDenied,
    
    /// <summary>
    /// Cancellation request has been rejected for further processing due to system (data) reasons.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_VpiZZNp-Ed-ak6NoX_4Aeg_-1596634915")]
    [Description(@"Cancellation request has been rejected for further processing due to system (data) reasons.")]
    CancellationRejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MeetingInstructionCancellationStatusCodeMetadataExtensions
{
    private static readonly MeetingInstructionCancellationStatusCodeDropdownSource _dropdownSource = new MeetingInstructionCancellationStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMeetingInstructionCancellationStatusCodeDropdownRow GetMetadata(this MeetingInstructionCancellationStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


