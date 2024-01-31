﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxType15Code.  ISO2002 ID# _TRd1mQEcEeCQm6a_G2yO_w_-1182449041.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxType15CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TRd1mQEcEeCQm6a_G2yO_w_-1182449041")]
public partial class TaxType15CodeDropdownSource : EnumMetadataManager<TaxType15Code,ITaxType15CodeDropdownRow,TaxType15CodeDropdownRow>
{
    public TaxType15CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxType15CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
