﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProductType6Code.  ISO2002 ID# _3dMpEDXvEemdWfjs3tykFQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying type of product or financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProductType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3dMpEDXvEemdWfjs3tykFQ")]
public partial class ProductType6CodeDropdownSource : EnumMetadataManager<ProductType6Code,IProductType6CodeDropdownRow,ProductType6CodeDropdownRow>
{
    public ProductType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProductType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
