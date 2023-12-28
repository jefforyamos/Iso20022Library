﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxType7Code.  ISO2002 ID# _VhCksNp-Ed-ak6NoX_4Aeg_-1748549305.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VhCksNp-Ed-ak6NoX_4Aeg_-1748549305")]
public partial class TaxType7CodeDropdownSource : EnumMetadataManager<TaxType7Code,ITaxType7CodeDropdownRow,TaxType7CodeDropdownRow>
{
    public TaxType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
