﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountManagementStatus1Code.  ISO2002 ID# _bqbk1tp-Ed-ak6NoX_4Aeg_226141002.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an account management instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountManagementStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bqbk1tp-Ed-ak6NoX_4Aeg_226141002")]
public partial class AccountManagementStatus1CodeDropdownSource : EnumMetadataManager<AccountManagementStatus1Code,IAccountManagementStatus1CodeDropdownRow,AccountManagementStatus1CodeDropdownRow>
{
    public AccountManagementStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountManagementStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
