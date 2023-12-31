﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OrderQuantityType3Code.  ISO2002 ID# _aRVD49p-Ed-ak6NoX_4Aeg_-1276786595.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the order is placed, for example by quantity of units or by amount of money.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OrderQuantityType3CodeDropdownSource"/>.
/// Implements <seealso cref="IOrderQuantityType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aRVD49p-Ed-ak6NoX_4Aeg_-1276786595")]
public partial class OrderQuantityType3CodeDropdownRow : EnumMetadataItem<OrderQuantityType3Code>, IOrderQuantityType3CodeDropdownRow
{
    /// <summary>
    /// Specifies how the order is placed, for example by quantity of units or by amount of money.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OrderQuantityType3CodeDropdownRow(OrderQuantityType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
