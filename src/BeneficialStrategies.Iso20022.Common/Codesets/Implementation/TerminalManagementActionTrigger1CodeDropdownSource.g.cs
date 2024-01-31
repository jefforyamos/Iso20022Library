﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TerminalManagementActionTrigger1Code.  ISO2002 ID# _KUOSlX1DEeCF8NjrBemJWQ_917878149.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Event to start a terminal management action by the point of interaction (POI).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITerminalManagementActionTrigger1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KUOSlX1DEeCF8NjrBemJWQ_917878149")]
public partial class TerminalManagementActionTrigger1CodeDropdownSource : EnumMetadataManager<TerminalManagementActionTrigger1Code,ITerminalManagementActionTrigger1CodeDropdownRow,TerminalManagementActionTrigger1CodeDropdownRow>
{
    public TerminalManagementActionTrigger1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TerminalManagementActionTrigger1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
