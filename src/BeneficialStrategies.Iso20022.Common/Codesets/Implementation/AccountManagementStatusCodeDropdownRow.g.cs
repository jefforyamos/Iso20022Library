﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountManagementStatusCode.  ISO2002 ID# _bqlV09p-Ed-ak6NoX_4Aeg_176271984.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an account management instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountManagementStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IAccountManagementStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bqlV09p-Ed-ak6NoX_4Aeg_176271984")]
public partial class AccountManagementStatusCodeDropdownRow : EnumMetadataItem<AccountManagementStatusCode>, IAccountManagementStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an account management instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountManagementStatusCodeDropdownRow(AccountManagementStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
