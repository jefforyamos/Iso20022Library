﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SwitchTypeCode.  ISO2002 ID# _RQTCAQ2XEeStB9HSJRk0Qw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the switch either full or part for a given account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SwitchTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ISwitchTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RQTCAQ2XEeStB9HSJRk0Qw")]
public partial class SwitchTypeCodeDropdownRow : EnumMetadataItem<SwitchTypeCode>, ISwitchTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of the switch either full or part for a given account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SwitchTypeCodeDropdownRow(SwitchTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
