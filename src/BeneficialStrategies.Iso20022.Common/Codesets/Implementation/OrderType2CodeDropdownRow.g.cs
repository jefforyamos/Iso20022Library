﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OrderType2Code.  ISO2002 ID# _aTQ9ltp-Ed-ak6NoX_4Aeg_-82502166.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of order based on the Financial Information Exchange Protocol.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OrderType2CodeDropdownSource"/>.
/// Implements <seealso cref="IOrderType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aTQ9ltp-Ed-ak6NoX_4Aeg_-82502166")]
public partial class OrderType2CodeDropdownRow : EnumMetadataItem<OrderType2Code>, IOrderType2CodeDropdownRow
{
    /// <summary>
    /// Specifies a type of order based on the Financial Information Exchange Protocol.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OrderType2CodeDropdownRow(OrderType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
