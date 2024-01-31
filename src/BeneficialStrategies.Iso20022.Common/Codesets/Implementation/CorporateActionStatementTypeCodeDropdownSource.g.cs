﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionStatementTypeCode.  ISO2002 ID# _bTMJhdp-Ed-ak6NoX_4Aeg_-454336053.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the statement contains missing instructions only or all instructions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionStatementTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bTMJhdp-Ed-ak6NoX_4Aeg_-454336053")]
public partial class CorporateActionStatementTypeCodeDropdownSource : EnumMetadataManager<CorporateActionStatementTypeCode,ICorporateActionStatementTypeCodeDropdownRow,CorporateActionStatementTypeCodeDropdownRow>
{
    public CorporateActionStatementTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionStatementTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
