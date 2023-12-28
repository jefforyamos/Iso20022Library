﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProductIdentifier2Code.  ISO2002 ID# _ZVuXR9p-Ed-ak6NoX_4Aeg_1808391573.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of identifier of a product.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProductIdentifier2CodeDropdownSource"/>.
/// Implements <seealso cref="IProductIdentifier2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZVuXR9p-Ed-ak6NoX_4Aeg_1808391573")]
public partial class ProductIdentifier2CodeDropdownRow : EnumMetadataItem<ProductIdentifier2Code>, IProductIdentifier2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of identifier of a product.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProductIdentifier2CodeDropdownRow(ProductIdentifier2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}