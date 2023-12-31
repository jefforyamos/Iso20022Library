﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CashClearingSystem2Code.  ISO2002 ID# _a4g_sdp-Ed-ak6NoX_4Aeg_-736776855.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of payment system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CashClearingSystem2CodeDropdownSource"/>.
/// Implements <seealso cref="ICashClearingSystem2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a4g_sdp-Ed-ak6NoX_4Aeg_-736776855")]
public partial class CashClearingSystem2CodeDropdownRow : EnumMetadataItem<CashClearingSystem2Code>, ICashClearingSystem2CodeDropdownRow
{
    /// <summary>
    /// Specifies a type of payment system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CashClearingSystem2CodeDropdownRow(CashClearingSystem2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
