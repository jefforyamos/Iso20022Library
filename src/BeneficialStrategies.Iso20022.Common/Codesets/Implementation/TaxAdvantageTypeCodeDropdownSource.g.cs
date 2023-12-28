﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxAdvantageTypeCode.  ISO2002 ID# _8nnPAVf1EeOuDtoQo1qilA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code for the form of tax advantage on the dividend.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxAdvantageTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8nnPAVf1EeOuDtoQo1qilA")]
public partial class TaxAdvantageTypeCodeDropdownSource : EnumMetadataManager<TaxAdvantageTypeCode,ITaxAdvantageTypeCodeDropdownRow,TaxAdvantageTypeCodeDropdownRow>
{
    public TaxAdvantageTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxAdvantageTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}