﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProductIdentifierCode.  ISO2002 ID# _ZV3hOdp-Ed-ak6NoX_4Aeg_1219289935.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of identifier of a product.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProductIdentifierCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZV3hOdp-Ed-ak6NoX_4Aeg_1219289935")]
public partial class ProductIdentifierCodeDropdownSource : EnumMetadataManager<ProductIdentifierCode,IProductIdentifierCodeDropdownRow,ProductIdentifierCodeDropdownRow>
{
    public ProductIdentifierCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProductIdentifierCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
