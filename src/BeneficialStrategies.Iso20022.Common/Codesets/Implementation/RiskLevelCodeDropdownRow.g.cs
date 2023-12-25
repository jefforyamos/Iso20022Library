﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RiskLevelCode.  ISO2002 ID# _v_E8ExdwEeKYM7Bc71nDlA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the risk level.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RiskLevelCodeDropdownSource"/>.
/// Implements <seealso cref="IRiskLevelCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_v_E8ExdwEeKYM7Bc71nDlA")]
public partial class RiskLevelCodeDropdownRow : EnumMetadataItem<RiskLevelCode>, IRiskLevelCodeDropdownRow
{
    /// <summary>
    /// Specifies the risk level.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RiskLevelCodeDropdownRow(RiskLevelCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
