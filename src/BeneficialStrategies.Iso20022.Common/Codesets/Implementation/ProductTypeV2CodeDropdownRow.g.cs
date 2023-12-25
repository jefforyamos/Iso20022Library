﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProductTypeV2Code.  ISO2002 ID# _g9bYnwOEEeWs3sTa9Sj6Lg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of product or financial instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProductTypeV2CodeDropdownSource"/>.
/// Implements <seealso cref="IProductTypeV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_g9bYnwOEEeWs3sTa9Sj6Lg")]
public partial class ProductTypeV2CodeDropdownRow : EnumMetadataItem<ProductTypeV2Code>, IProductTypeV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of product or financial instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProductTypeV2CodeDropdownRow(ProductTypeV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
