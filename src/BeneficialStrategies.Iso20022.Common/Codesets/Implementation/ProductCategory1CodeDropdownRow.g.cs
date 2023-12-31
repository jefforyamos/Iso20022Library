﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProductCategory1Code.  ISO2002 ID# _aLN02Np-Ed-ak6NoX_4Aeg_1399265867.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of a product.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProductCategory1CodeDropdownSource"/>.
/// Implements <seealso cref="IProductCategory1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aLN02Np-Ed-ak6NoX_4Aeg_1399265867")]
public partial class ProductCategory1CodeDropdownRow : EnumMetadataItem<ProductCategory1Code>, IProductCategory1CodeDropdownRow
{
    /// <summary>
    /// Specifies the category of a product.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProductCategory1CodeDropdownRow(ProductCategory1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
