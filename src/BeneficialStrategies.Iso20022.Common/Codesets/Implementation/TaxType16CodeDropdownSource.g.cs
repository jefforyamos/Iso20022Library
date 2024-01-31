﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxType16Code.  ISO2002 ID# _kiNHQBuGEeOqSdXzJ0oydA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxType16CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kiNHQBuGEeOqSdXzJ0oydA")]
public partial class TaxType16CodeDropdownSource : EnumMetadataManager<TaxType16Code,ITaxType16CodeDropdownRow,TaxType16CodeDropdownRow>
{
    public TaxType16CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxType16CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
