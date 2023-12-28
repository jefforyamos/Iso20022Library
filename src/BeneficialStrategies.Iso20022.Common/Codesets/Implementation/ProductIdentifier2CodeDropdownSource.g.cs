﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProductIdentifier2Code.  ISO2002 ID# _ZVuXR9p-Ed-ak6NoX_4Aeg_1808391573.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of identifier of a product.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProductIdentifier2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZVuXR9p-Ed-ak6NoX_4Aeg_1808391573")]
public partial class ProductIdentifier2CodeDropdownSource : EnumMetadataManager<ProductIdentifier2Code,IProductIdentifier2CodeDropdownRow,ProductIdentifier2CodeDropdownRow>
{
    public ProductIdentifier2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProductIdentifier2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}