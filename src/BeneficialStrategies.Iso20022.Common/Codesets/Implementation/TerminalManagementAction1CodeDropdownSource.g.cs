﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TerminalManagementAction1Code.  ISO2002 ID# _KTertX1DEeCF8NjrBemJWQ_-2129666460.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITerminalManagementAction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KTertX1DEeCF8NjrBemJWQ_-2129666460")]
public partial class TerminalManagementAction1CodeDropdownSource : EnumMetadataManager<TerminalManagementAction1Code,ITerminalManagementAction1CodeDropdownRow,TerminalManagementAction1CodeDropdownRow>
{
    public TerminalManagementAction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TerminalManagementAction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
