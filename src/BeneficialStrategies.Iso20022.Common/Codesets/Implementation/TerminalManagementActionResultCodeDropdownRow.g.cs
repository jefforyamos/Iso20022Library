﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TerminalManagementActionResultCode.  ISO2002 ID# _KT7Xp31DEeCF8NjrBemJWQ_-1645762165.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Final result of the processed terminal management action.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TerminalManagementActionResultCodeDropdownSource"/>.
/// Implements <seealso cref="ITerminalManagementActionResultCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KT7Xp31DEeCF8NjrBemJWQ_-1645762165")]
public partial class TerminalManagementActionResultCodeDropdownRow : EnumMetadataItem<TerminalManagementActionResultCode>, ITerminalManagementActionResultCodeDropdownRow
{
    /// <summary>
    /// Final result of the processed terminal management action.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TerminalManagementActionResultCodeDropdownRow(TerminalManagementActionResultCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}