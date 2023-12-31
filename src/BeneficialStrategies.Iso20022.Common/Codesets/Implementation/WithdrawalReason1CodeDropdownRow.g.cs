﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for WithdrawalReason1Code.  ISO2002 ID# _x_1NIJElEeKcLcxonNWTXg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason that an alleged trade is withdrawn.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="WithdrawalReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IWithdrawalReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_x_1NIJElEeKcLcxonNWTXg")]
public partial class WithdrawalReason1CodeDropdownRow : EnumMetadataItem<WithdrawalReason1Code>, IWithdrawalReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason that an alleged trade is withdrawn.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public WithdrawalReason1CodeDropdownRow(WithdrawalReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
