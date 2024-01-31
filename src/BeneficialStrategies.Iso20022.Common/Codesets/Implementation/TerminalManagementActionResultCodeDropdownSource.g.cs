﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TerminalManagementActionResultCode.  ISO2002 ID# _KT7Xp31DEeCF8NjrBemJWQ_-1645762165.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Final result of the processed terminal management action.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITerminalManagementActionResultCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KT7Xp31DEeCF8NjrBemJWQ_-1645762165")]
public partial class TerminalManagementActionResultCodeDropdownSource : EnumMetadataManager<TerminalManagementActionResultCode,ITerminalManagementActionResultCodeDropdownRow,TerminalManagementActionResultCodeDropdownRow>
{
    public TerminalManagementActionResultCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TerminalManagementActionResultCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
