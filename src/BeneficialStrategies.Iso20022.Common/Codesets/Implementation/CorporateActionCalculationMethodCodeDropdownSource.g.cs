﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionCalculationMethodCode.  ISO2002 ID# _bCgCJ9p-Ed-ak6NoX_4Aeg_734426913.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the calculation method.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionCalculationMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bCgCJ9p-Ed-ak6NoX_4Aeg_734426913")]
public partial class CorporateActionCalculationMethodCodeDropdownSource : EnumMetadataManager<CorporateActionCalculationMethodCode,ICorporateActionCalculationMethodCodeDropdownRow,CorporateActionCalculationMethodCodeDropdownRow>
{
    public CorporateActionCalculationMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionCalculationMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}