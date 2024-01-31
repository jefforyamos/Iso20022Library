﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProductTypeV2Code.  ISO2002 ID# _g9bYnwOEEeWs3sTa9Sj6Lg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of product or financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProductTypeV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_g9bYnwOEEeWs3sTa9Sj6Lg")]
public partial class ProductTypeV2CodeDropdownSource : EnumMetadataManager<ProductTypeV2Code,IProductTypeV2CodeDropdownRow,ProductTypeV2CodeDropdownRow>
{
    public ProductTypeV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProductTypeV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
