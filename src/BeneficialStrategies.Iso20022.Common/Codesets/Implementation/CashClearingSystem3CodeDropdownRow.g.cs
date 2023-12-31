﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CashClearingSystem3Code.  ISO2002 ID# _a4g_ttp-Ed-ak6NoX_4Aeg_136709281.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CashClearingSystem3CodeDropdownSource"/>.
/// Implements <seealso cref="ICashClearingSystem3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a4g_ttp-Ed-ak6NoX_4Aeg_136709281")]
public partial class CashClearingSystem3CodeDropdownRow : EnumMetadataItem<CashClearingSystem3Code>, ICashClearingSystem3CodeDropdownRow
{
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CashClearingSystem3CodeDropdownRow(CashClearingSystem3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
