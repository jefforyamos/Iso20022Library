﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceType12Code.  ISO2002 ID# _bmQ2gtp-Ed-ak6NoX_4Aeg_1716764065.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the balance type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceType12CodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceType12CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bmQ2gtp-Ed-ak6NoX_4Aeg_1716764065")]
public partial class BalanceType12CodeDropdownRow : EnumMetadataItem<BalanceType12Code>, IBalanceType12CodeDropdownRow
{
    /// <summary>
    /// Specifies the balance type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceType12CodeDropdownRow(BalanceType12Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}