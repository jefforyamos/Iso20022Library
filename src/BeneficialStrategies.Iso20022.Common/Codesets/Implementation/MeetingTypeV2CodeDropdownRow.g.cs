﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MeetingTypeV2Code.  ISO2002 ID# _Oq2Raq7DEemG7MmivSuE5g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of security holders meeting.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MeetingTypeV2CodeDropdownSource"/>.
/// Implements <seealso cref="IMeetingTypeV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Oq2Raq7DEemG7MmivSuE5g")]
public partial class MeetingTypeV2CodeDropdownRow : EnumMetadataItem<MeetingTypeV2Code>, IMeetingTypeV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of security holders meeting.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MeetingTypeV2CodeDropdownRow(MeetingTypeV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
