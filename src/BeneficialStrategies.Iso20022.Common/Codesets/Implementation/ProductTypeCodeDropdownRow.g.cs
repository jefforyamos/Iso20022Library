﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProductTypeCode.  ISO2002 ID# _ZWUNI9p-Ed-ak6NoX_4Aeg_1984550487.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of product or financial instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProductTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IProductTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZWUNI9p-Ed-ak6NoX_4Aeg_1984550487")]
public partial class ProductTypeCodeDropdownRow : EnumMetadataItem<ProductTypeCode>, IProductTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of product or financial instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProductTypeCodeDropdownRow(ProductTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
