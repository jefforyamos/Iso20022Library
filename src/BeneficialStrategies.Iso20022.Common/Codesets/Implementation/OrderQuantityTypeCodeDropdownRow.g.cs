﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OrderQuantityTypeCode.  ISO2002 ID# _aRVD59p-Ed-ak6NoX_4Aeg_-319440710.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the order is placed, eg by quantity of units or by amount of money.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OrderQuantityTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IOrderQuantityTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aRVD59p-Ed-ak6NoX_4Aeg_-319440710")]
public partial class OrderQuantityTypeCodeDropdownRow : EnumMetadataItem<OrderQuantityTypeCode>, IOrderQuantityTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies how the order is placed, eg by quantity of units or by amount of money.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OrderQuantityTypeCodeDropdownRow(OrderQuantityTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
