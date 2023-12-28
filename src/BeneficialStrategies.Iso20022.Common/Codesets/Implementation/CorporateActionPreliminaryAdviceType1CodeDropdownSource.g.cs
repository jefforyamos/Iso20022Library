﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionPreliminaryAdviceType1Code.  ISO2002 ID# _bRs7x9p-Ed-ak6NoX_4Aeg_-934341596.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of movement preliminary advice.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionPreliminaryAdviceType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bRs7x9p-Ed-ak6NoX_4Aeg_-934341596")]
public partial class CorporateActionPreliminaryAdviceType1CodeDropdownSource : EnumMetadataManager<CorporateActionPreliminaryAdviceType1Code,ICorporateActionPreliminaryAdviceType1CodeDropdownRow,CorporateActionPreliminaryAdviceType1CodeDropdownRow>
{
    public CorporateActionPreliminaryAdviceType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionPreliminaryAdviceType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
