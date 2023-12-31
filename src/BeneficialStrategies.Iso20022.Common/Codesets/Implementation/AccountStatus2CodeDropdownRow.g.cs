﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountStatus2Code.  ISO2002 ID# _bretttp-Ed-ak6NoX_4Aeg_-674425940.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualifies further the current state of an account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bretttp-Ed-ak6NoX_4Aeg_-674425940")]
public partial class AccountStatus2CodeDropdownRow : EnumMetadataItem<AccountStatus2Code>, IAccountStatus2CodeDropdownRow
{
    /// <summary>
    /// Qualifies further the current state of an account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountStatus2CodeDropdownRow(AccountStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
