﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TerminalManagementAction3Code.  ISO2002 ID# _pzYu4I34EeWRwov1g9WL_A.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to perform.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITerminalManagementAction3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pzYu4I34EeWRwov1g9WL_A")]
public partial class TerminalManagementAction3CodeDropdownSource : EnumMetadataManager<TerminalManagementAction3Code,ITerminalManagementAction3CodeDropdownRow,TerminalManagementAction3CodeDropdownRow>
{
    public TerminalManagementAction3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TerminalManagementAction3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
