﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StatementType1Code.  ISO2002 ID# _ZQM-E9p-Ed-ak6NoX_4Aeg_757727458.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the statement message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatementType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZQM-E9p-Ed-ak6NoX_4Aeg_757727458")]
public partial class StatementType1CodeDropdownSource : EnumMetadataManager<StatementType1Code,IStatementType1CodeDropdownRow,StatementType1CodeDropdownRow>
{
    public StatementType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new StatementType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
