﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RankCode.  ISO2002 ID# _luIM4C1hEeGp2Zpvgj9Dtw_108025912.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the rank of an element (party, market) in a specific environment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RankCodeDropdownSource"/>.
/// Implements <seealso cref="IRankCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_luIM4C1hEeGp2Zpvgj9Dtw_108025912")]
public partial class RankCodeDropdownRow : EnumMetadataItem<RankCode>, IRankCodeDropdownRow
{
    /// <summary>
    /// Specifies the rank of an element (party, market) in a specific environment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RankCodeDropdownRow(RankCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
