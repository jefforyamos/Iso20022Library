﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountUsageType1Code.  ISO2002 ID# _mtUTQBKCEeKj15WxqwlXPw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of usage of the account.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountUsageType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mtUTQBKCEeKj15WxqwlXPw")]
public partial class AccountUsageType1CodeDropdownSource : EnumMetadataManager<AccountUsageType1Code,IAccountUsageType1CodeDropdownRow,AccountUsageType1CodeDropdownRow>
{
    public AccountUsageType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountUsageType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
