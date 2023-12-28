﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProductStructure1Code.  ISO2002 ID# _-ycnIKDqEequlaOyi6MUhw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the structure of a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProductStructure1CodeDropdownSource"/>.
/// Implements <seealso cref="IProductStructure1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-ycnIKDqEequlaOyi6MUhw")]
public partial class ProductStructure1CodeDropdownRow : EnumMetadataItem<ProductStructure1Code>, IProductStructure1CodeDropdownRow
{
    /// <summary>
    /// Specifies the structure of a financial instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProductStructure1CodeDropdownRow(ProductStructure1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
