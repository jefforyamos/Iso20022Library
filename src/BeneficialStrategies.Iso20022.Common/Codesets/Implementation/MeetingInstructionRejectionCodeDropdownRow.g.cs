﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MeetingInstructionRejectionCode.  ISO2002 ID# _VpFtddp-Ed-ak6NoX_4Aeg_-315431614.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the possible rejection reasons.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MeetingInstructionRejectionCodeDropdownSource"/>.
/// Implements <seealso cref="IMeetingInstructionRejectionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VpFtddp-Ed-ak6NoX_4Aeg_-315431614")]
public partial class MeetingInstructionRejectionCodeDropdownRow : EnumMetadataItem<MeetingInstructionRejectionCode>, IMeetingInstructionRejectionCodeDropdownRow
{
    /// <summary>
    /// Identifies the possible rejection reasons.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MeetingInstructionRejectionCodeDropdownRow(MeetingInstructionRejectionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}