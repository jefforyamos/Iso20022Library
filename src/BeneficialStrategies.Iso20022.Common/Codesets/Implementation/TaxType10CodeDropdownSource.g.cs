﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxType10Code.  ISO2002 ID# _YjqBINp-Ed-ak6NoX_4Aeg_-1712835689.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxType10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YjqBINp-Ed-ak6NoX_4Aeg_-1712835689")]
public partial class TaxType10CodeDropdownSource : EnumMetadataManager<TaxType10Code,ITaxType10CodeDropdownRow,TaxType10CodeDropdownRow>
{
    public TaxType10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxType10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
