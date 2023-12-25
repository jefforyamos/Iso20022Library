﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxLiabilityCode.  ISO2002 ID# _YiBCZNp-Ed-ak6NoX_4Aeg_14926888.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the tax role capacity of the instructing party.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxLiabilityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YiBCZNp-Ed-ak6NoX_4Aeg_14926888")]
public partial class TaxLiabilityCodeDropdownSource : EnumMetadataManager<TaxLiabilityCode,ITaxLiabilityCodeDropdownRow,TaxLiabilityCodeDropdownRow>
{
    public TaxLiabilityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxLiabilityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
