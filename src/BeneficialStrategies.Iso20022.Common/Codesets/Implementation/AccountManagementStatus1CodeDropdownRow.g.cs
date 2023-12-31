﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountManagementStatus1Code.  ISO2002 ID# _bqbk1tp-Ed-ak6NoX_4Aeg_226141002.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an account management instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountManagementStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountManagementStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bqbk1tp-Ed-ak6NoX_4Aeg_226141002")]
public partial class AccountManagementStatus1CodeDropdownRow : EnumMetadataItem<AccountManagementStatus1Code>, IAccountManagementStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an account management instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountManagementStatus1CodeDropdownRow(AccountManagementStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
