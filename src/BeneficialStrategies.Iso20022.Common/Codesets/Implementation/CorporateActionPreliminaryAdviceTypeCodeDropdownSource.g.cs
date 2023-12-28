﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionPreliminaryAdviceTypeCode.  ISO2002 ID# _bR2FsNp-Ed-ak6NoX_4Aeg_570400157.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of movement preliminary advice.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionPreliminaryAdviceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bR2FsNp-Ed-ak6NoX_4Aeg_570400157")]
public partial class CorporateActionPreliminaryAdviceTypeCodeDropdownSource : EnumMetadataManager<CorporateActionPreliminaryAdviceTypeCode,ICorporateActionPreliminaryAdviceTypeCodeDropdownRow,CorporateActionPreliminaryAdviceTypeCodeDropdownRow>
{
    public CorporateActionPreliminaryAdviceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionPreliminaryAdviceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}