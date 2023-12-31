﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SystemBalanceType1Code.  ISO2002 ID# _8MlMhKMgEeCJ6YNENx4h-w_949117902.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the system balance, such as opening balance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SystemBalanceType1CodeDropdownSource"/>.
/// Implements <seealso cref="ISystemBalanceType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8MlMhKMgEeCJ6YNENx4h-w_949117902")]
public partial class SystemBalanceType1CodeDropdownRow : EnumMetadataItem<SystemBalanceType1Code>, ISystemBalanceType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the system balance, such as opening balance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SystemBalanceType1CodeDropdownRow(SystemBalanceType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
