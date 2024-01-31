﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountUsageType2Code.  ISO2002 ID# _CYsHEL-FEeWfsa741pI6WA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of usage of the account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountUsageType2CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountUsageType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CYsHEL-FEeWfsa741pI6WA")]
public partial class AccountUsageType2CodeDropdownRow : EnumMetadataItem<AccountUsageType2Code>, IAccountUsageType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of usage of the account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountUsageType2CodeDropdownRow(AccountUsageType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
