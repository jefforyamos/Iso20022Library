﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CashClearingSystemCode.  ISO2002 ID# _a5tSg9p-Ed-ak6NoX_4Aeg_381100265.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CashClearingSystemCodeDropdownSource"/>.
/// Implements <seealso cref="ICashClearingSystemCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a5tSg9p-Ed-ak6NoX_4Aeg_381100265")]
public partial class CashClearingSystemCodeDropdownRow : EnumMetadataItem<CashClearingSystemCode>, ICashClearingSystemCodeDropdownRow
{
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CashClearingSystemCodeDropdownRow(CashClearingSystemCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}