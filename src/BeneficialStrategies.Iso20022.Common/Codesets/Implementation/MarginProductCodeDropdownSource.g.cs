﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MarginProductCode.  ISO2002 ID# _YZq-t9p-Ed-ak6NoX_4Aeg_1067655731.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying product of the margin.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMarginProductCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YZq-t9p-Ed-ak6NoX_4Aeg_1067655731")]
public partial class MarginProductCodeDropdownSource : EnumMetadataManager<MarginProductCode,IMarginProductCodeDropdownRow,MarginProductCodeDropdownRow>
{
    public MarginProductCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MarginProductCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
