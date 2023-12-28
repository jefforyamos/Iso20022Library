﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MeetingCancellationReason1Code.  ISO2002 ID# _Vp1UVtp-Ed-ak6NoX_4Aeg_-1464937039.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MeetingCancellationReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IMeetingCancellationReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vp1UVtp-Ed-ak6NoX_4Aeg_-1464937039")]
public partial class MeetingCancellationReason1CodeDropdownRow : EnumMetadataItem<MeetingCancellationReason1Code>, IMeetingCancellationReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for cancelling a meeting.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MeetingCancellationReason1CodeDropdownRow(MeetingCancellationReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}