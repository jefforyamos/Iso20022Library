﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MeetingCancellationReason1Code.  ISO2002 ID# _Vp1UVtp-Ed-ak6NoX_4Aeg_-1464937039.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vp1UVtp-Ed-ak6NoX_4Aeg_-1464937039")]
[Description(@"Specifies the reason for cancelling a meeting.")]
[DerivedFrom(typeof(MeetingCancellationReasonCode))]
public enum MeetingCancellationReason1Code
{
    /// <summary>
    /// Cancellation due to insufficient participation to the vote.
    /// Encoded/decoded by serializers as "Quorum".
    /// </summary>
    [EnumMember(Value = "QORM")]
    [IsoId("_Vp_FUNp-Ed-ak6NoX_4Aeg_-1410451064")]
    [Description(@"Cancellation due to insufficient participation to the vote.")]
    Quorum,
    
    /// <summary>
    /// Cancellation due to a processing error.
    /// Encoded/decoded by serializers as "Processing".
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_Vp_FUdp-Ed-ak6NoX_4Aeg_-1398443912")]
    [Description(@"Cancellation due to a processing error.")]
    Processing,
    
    /// <summary>
    /// Cancellation due to another reason.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vp_FUtp-Ed-ak6NoX_4Aeg_-1315309873")]
    [Description(@"Cancellation due to another reason.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MeetingCancellationReason1CodeMetadataExtensions
{
    private static readonly MeetingCancellationReason1CodeDropdownSource _dropdownSource = new MeetingCancellationReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMeetingCancellationReason1CodeDropdownRow GetMetadata(this MeetingCancellationReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


