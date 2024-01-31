﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxableIncomePerShareCalculatedCode.  ISO2002 ID# _ZSSoyNp-Ed-ak6NoX_4Aeg_1980815659.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the fund calculates a taxable interest per share (TIS).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxableIncomePerShareCalculatedCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZSSoyNp-Ed-ak6NoX_4Aeg_1980815659")]
public partial class TaxableIncomePerShareCalculatedCodeDropdownSource : EnumMetadataManager<TaxableIncomePerShareCalculatedCode,ITaxableIncomePerShareCalculatedCodeDropdownRow,TaxableIncomePerShareCalculatedCodeDropdownRow>
{
    public TaxableIncomePerShareCalculatedCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxableIncomePerShareCalculatedCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
