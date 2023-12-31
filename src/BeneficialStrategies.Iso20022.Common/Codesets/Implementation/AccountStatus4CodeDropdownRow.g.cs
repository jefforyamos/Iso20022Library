﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountStatus4Code.  ISO2002 ID# _VfjYECF1EeW9XJWqfgXIIA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountStatus4CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountStatus4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VfjYECF1EeW9XJWqfgXIIA")]
public partial class AccountStatus4CodeDropdownRow : EnumMetadataItem<AccountStatus4Code>, IAccountStatus4CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountStatus4CodeDropdownRow(AccountStatus4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
