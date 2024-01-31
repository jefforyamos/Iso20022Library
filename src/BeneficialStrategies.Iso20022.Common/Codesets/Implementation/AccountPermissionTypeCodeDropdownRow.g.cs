﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountPermissionTypeCode.  ISO2002 ID# _fJFegJiuEeO4o528ngEXuw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies different levels of permission.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountPermissionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAccountPermissionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fJFegJiuEeO4o528ngEXuw")]
public partial class AccountPermissionTypeCodeDropdownRow : EnumMetadataItem<AccountPermissionTypeCode>, IAccountPermissionTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies different levels of permission.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountPermissionTypeCodeDropdownRow(AccountPermissionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
