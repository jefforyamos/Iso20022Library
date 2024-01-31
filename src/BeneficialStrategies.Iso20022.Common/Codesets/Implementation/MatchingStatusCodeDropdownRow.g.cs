﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MatchingStatusCode.  ISO2002 ID# _aVDGRtp-Ed-ak6NoX_4Aeg_162716149.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the matching status of the instruction at the time the settlement instruction was sent.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MatchingStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IMatchingStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aVDGRtp-Ed-ak6NoX_4Aeg_162716149")]
public partial class MatchingStatusCodeDropdownRow : EnumMetadataItem<MatchingStatusCode>, IMatchingStatusCodeDropdownRow
{
    /// <summary>
    /// Provides the matching status of the instruction at the time the settlement instruction was sent.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MatchingStatusCodeDropdownRow(MatchingStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
