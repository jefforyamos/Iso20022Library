﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CaseAssignmentRejection2Code.  ISO2002 ID# _a2IaEdp-Ed-ak6NoX_4Aeg_-2044863229.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for not accepting a Case.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICaseAssignmentRejection2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a2IaEdp-Ed-ak6NoX_4Aeg_-2044863229")]
public partial class CaseAssignmentRejection2CodeDropdownSource : EnumMetadataManager<CaseAssignmentRejection2Code,ICaseAssignmentRejection2CodeDropdownRow,CaseAssignmentRejection2CodeDropdownRow>
{
    public CaseAssignmentRejection2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CaseAssignmentRejection2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
