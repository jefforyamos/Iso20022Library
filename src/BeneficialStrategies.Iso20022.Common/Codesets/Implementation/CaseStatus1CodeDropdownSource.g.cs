﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CaseStatus1Code.  ISO2002 ID# _VnJzwdp-Ed-ak6NoX_4Aeg_-1043344711.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an investigation case.||Note: |The Cases that have been rejected (not accepted) are unknown to the Party reporting the status of cases. They will be reported with the CaseStatusCode = Unknown.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICaseStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VnJzwdp-Ed-ak6NoX_4Aeg_-1043344711")]
public partial class CaseStatus1CodeDropdownSource : EnumMetadataManager<CaseStatus1Code,ICaseStatus1CodeDropdownRow,CaseStatus1CodeDropdownRow>
{
    public CaseStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CaseStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
