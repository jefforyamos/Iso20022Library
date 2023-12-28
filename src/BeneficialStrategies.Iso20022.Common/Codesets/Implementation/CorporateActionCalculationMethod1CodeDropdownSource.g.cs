﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionCalculationMethod1Code.  ISO2002 ID# _bCgCItp-Ed-ak6NoX_4Aeg_-666370508.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the calculation method for drawings.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionCalculationMethod1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bCgCItp-Ed-ak6NoX_4Aeg_-666370508")]
public partial class CorporateActionCalculationMethod1CodeDropdownSource : EnumMetadataManager<CorporateActionCalculationMethod1Code,ICorporateActionCalculationMethod1CodeDropdownRow,CorporateActionCalculationMethod1CodeDropdownRow>
{
    public CorporateActionCalculationMethod1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionCalculationMethod1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}