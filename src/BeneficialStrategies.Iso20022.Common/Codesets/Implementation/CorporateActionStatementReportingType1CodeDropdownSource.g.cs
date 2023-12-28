﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionStatementReportingType1Code.  ISO2002 ID# _bTCYhdp-Ed-ak6NoX_4Aeg_2055089309.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of statement reporting on account holdings for corporate action events for example. reporting on multiple accounts or multiple events.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionStatementReportingType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bTCYhdp-Ed-ak6NoX_4Aeg_2055089309")]
public partial class CorporateActionStatementReportingType1CodeDropdownSource : EnumMetadataManager<CorporateActionStatementReportingType1Code,ICorporateActionStatementReportingType1CodeDropdownRow,CorporateActionStatementReportingType1CodeDropdownRow>
{
    public CorporateActionStatementReportingType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionStatementReportingType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}