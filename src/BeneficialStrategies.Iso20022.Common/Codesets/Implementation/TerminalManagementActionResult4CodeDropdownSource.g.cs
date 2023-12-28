﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TerminalManagementActionResult4Code.  ISO2002 ID# _4BQVUdwmEeeKpa-yxjuKzQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Final result of the processed terminal management action.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITerminalManagementActionResult4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4BQVUdwmEeeKpa-yxjuKzQ")]
public partial class TerminalManagementActionResult4CodeDropdownSource : EnumMetadataManager<TerminalManagementActionResult4Code,ITerminalManagementActionResult4CodeDropdownRow,TerminalManagementActionResult4CodeDropdownRow>
{
    public TerminalManagementActionResult4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TerminalManagementActionResult4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}