﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StatementSourceCode.  ISO2002 ID# _m5XidfNBEeCuA5Tr22BnwA_665404846.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the source of the report.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatementSourceCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_m5XidfNBEeCuA5Tr22BnwA_665404846")]
public partial class StatementSourceCodeDropdownSource : EnumMetadataManager<StatementSourceCode,IStatementSourceCodeDropdownRow,StatementSourceCodeDropdownRow>
{
    public StatementSourceCodeDropdownSource()
        : base( (enumValue, memberInfo) => new StatementSourceCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
