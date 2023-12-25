﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for VotingParticipationMethodV2Code.  ISO2002 ID# _JD_2QBrkEeyhRdHRjakS2w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="VotingParticipationMethodV2CodeDropdownSource"/>.
/// Implements <seealso cref="IVotingParticipationMethodV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JD_2QBrkEeyhRdHRjakS2w")]
public partial class VotingParticipationMethodV2CodeDropdownRow : EnumMetadataItem<VotingParticipationMethodV2Code>, IVotingParticipationMethodV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public VotingParticipationMethodV2CodeDropdownRow(VotingParticipationMethodV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
