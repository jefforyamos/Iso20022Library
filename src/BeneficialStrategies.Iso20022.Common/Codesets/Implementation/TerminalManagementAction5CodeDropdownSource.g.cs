﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TerminalManagementAction5Code.  ISO2002 ID# _GO0LkSiyEeurkfo6MpvKDA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITerminalManagementAction5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GO0LkSiyEeurkfo6MpvKDA")]
public partial class TerminalManagementAction5CodeDropdownSource : EnumMetadataManager<TerminalManagementAction5Code,ITerminalManagementAction5CodeDropdownRow,TerminalManagementAction5CodeDropdownRow>
{
    public TerminalManagementAction5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TerminalManagementAction5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
