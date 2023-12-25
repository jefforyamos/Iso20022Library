﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountTypeCode.  ISO2002 ID# _brxooNp-Ed-ak6NoX_4Aeg_-1139230209.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_brxooNp-Ed-ak6NoX_4Aeg_-1139230209")]
public partial class AccountTypeCodeDropdownSource : EnumMetadataManager<AccountTypeCode,IAccountTypeCodeDropdownRow,AccountTypeCodeDropdownRow>
{
    public AccountTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
