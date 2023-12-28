﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountPermissionTypeCode.  ISO2002 ID# _fJFegJiuEeO4o528ngEXuw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies different levels of permission.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountPermissionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fJFegJiuEeO4o528ngEXuw")]
public partial class AccountPermissionTypeCodeDropdownSource : EnumMetadataManager<AccountPermissionTypeCode,IAccountPermissionTypeCodeDropdownRow,AccountPermissionTypeCodeDropdownRow>
{
    public AccountPermissionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountPermissionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}