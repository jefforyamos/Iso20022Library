﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProductStructure1Code.  ISO2002 ID# _-ycnIKDqEequlaOyi6MUhw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the structure of a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProductStructure1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-ycnIKDqEequlaOyi6MUhw")]
public partial class ProductStructure1CodeDropdownSource : EnumMetadataManager<ProductStructure1Code,IProductStructure1CodeDropdownRow,ProductStructure1CodeDropdownRow>
{
    public ProductStructure1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProductStructure1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}