﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxExemptReason2Code.  ISO2002 ID# _VlEJGNp-Ed-ak6NoX_4Aeg_-1078452737.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxExemptReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VlEJGNp-Ed-ak6NoX_4Aeg_-1078452737")]
public partial class TaxExemptReason2CodeDropdownSource : EnumMetadataManager<TaxExemptReason2Code,ITaxExemptReason2CodeDropdownRow,TaxExemptReason2CodeDropdownRow>
{
    public TaxExemptReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxExemptReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
