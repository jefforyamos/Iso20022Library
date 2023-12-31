﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TerminalManagementActionCode.  ISO2002 ID# _KTocs31DEeCF8NjrBemJWQ_1816233839.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TerminalManagementActionCodeDropdownSource"/>.
/// Implements <seealso cref="ITerminalManagementActionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KTocs31DEeCF8NjrBemJWQ_1816233839")]
public partial class TerminalManagementActionCodeDropdownRow : EnumMetadataItem<TerminalManagementActionCode>, ITerminalManagementActionCodeDropdownRow
{
    /// <summary>
    /// Types of terminal management action to be performed by a point of interaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TerminalManagementActionCodeDropdownRow(TerminalManagementActionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
