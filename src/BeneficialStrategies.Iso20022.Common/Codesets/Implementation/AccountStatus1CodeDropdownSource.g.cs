﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountStatus1Code.  ISO2002 ID# _bretstp-Ed-ak6NoX_4Aeg_-2008339319.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualifies further the current state of an account.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bretstp-Ed-ak6NoX_4Aeg_-2008339319")]
public partial class AccountStatus1CodeDropdownSource : EnumMetadataManager<AccountStatus1Code,IAccountStatus1CodeDropdownRow,AccountStatus1CodeDropdownRow>
{
    public AccountStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
