﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CashMarginOrderCode.  ISO2002 ID# _a7DWUNp-Ed-ak6NoX_4Aeg_335335634.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies whether an order is a non-margin, an opening margin or a closing margin order.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CashMarginOrderCodeDropdownSource"/>.
/// Implements <seealso cref="ICashMarginOrderCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a7DWUNp-Ed-ak6NoX_4Aeg_335335634")]
public partial class CashMarginOrderCodeDropdownRow : EnumMetadataItem<CashMarginOrderCode>, ICashMarginOrderCodeDropdownRow
{
    /// <summary>
    /// Identifies whether an order is a non-margin, an opening margin or a closing margin order.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CashMarginOrderCodeDropdownRow(CashMarginOrderCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}