﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionStatementReportingTypeCode.  ISO2002 ID# _bTCYiNp-Ed-ak6NoX_4Aeg_263893387.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of statement reporting on account holdings for corporate action events eg. reporting on multiple accounts or multiple events.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionStatementReportingTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bTCYiNp-Ed-ak6NoX_4Aeg_263893387")]
public partial class CorporateActionStatementReportingTypeCodeDropdownSource : EnumMetadataManager<CorporateActionStatementReportingTypeCode,ICorporateActionStatementReportingTypeCodeDropdownRow,CorporateActionStatementReportingTypeCodeDropdownRow>
{
    public CorporateActionStatementReportingTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionStatementReportingTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
