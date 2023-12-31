﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StatementStatusTypeCode.  ISO2002 ID# _x8pjANBUEeiirviLm7P0IA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the report includes pending or settled transactions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatementStatusTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_x8pjANBUEeiirviLm7P0IA")]
public partial class StatementStatusTypeCodeDropdownSource : EnumMetadataManager<StatementStatusTypeCode,IStatementStatusTypeCodeDropdownRow,StatementStatusTypeCodeDropdownRow>
{
    public StatementStatusTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new StatementStatusTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
