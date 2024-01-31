﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxRecordCode.  ISO2002 ID# _YiKMVtp-Ed-ak6NoX_4Aeg_-1942037713.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax details.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxRecordCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YiKMVtp-Ed-ak6NoX_4Aeg_-1942037713")]
public partial class TaxRecordCodeDropdownSource : EnumMetadataManager<TaxRecordCode,ITaxRecordCodeDropdownRow,TaxRecordCodeDropdownRow>
{
    public TaxRecordCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxRecordCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
