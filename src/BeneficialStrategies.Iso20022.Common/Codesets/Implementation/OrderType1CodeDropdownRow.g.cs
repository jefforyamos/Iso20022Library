﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OrderType1Code.  ISO2002 ID# _aS0Rpdp-Ed-ak6NoX_4Aeg_-2117834119.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of instruction to a broker or dealer to buy or sell a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OrderType1CodeDropdownSource"/>.
/// Implements <seealso cref="IOrderType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aS0Rpdp-Ed-ak6NoX_4Aeg_-2117834119")]
public partial class OrderType1CodeDropdownRow : EnumMetadataItem<OrderType1Code>, IOrderType1CodeDropdownRow
{
    /// <summary>
    /// Indicates the type of instruction to a broker or dealer to buy or sell a financial instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OrderType1CodeDropdownRow(OrderType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
