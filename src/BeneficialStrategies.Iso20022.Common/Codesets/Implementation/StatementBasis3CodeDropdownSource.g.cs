﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StatementBasis3Code.  ISO2002 ID# _qaaAUMRxEeij-rSPpvD-Tw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the basis on which the statement is prepared expressed as a code.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatementBasis3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qaaAUMRxEeij-rSPpvD-Tw")]
public partial class StatementBasis3CodeDropdownSource : EnumMetadataManager<StatementBasis3Code,IStatementBasis3CodeDropdownRow,StatementBasis3CodeDropdownRow>
{
    public StatementBasis3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new StatementBasis3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
