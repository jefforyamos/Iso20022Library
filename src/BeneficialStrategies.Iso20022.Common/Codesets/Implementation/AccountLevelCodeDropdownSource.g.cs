﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountLevelCode.  ISO2002 ID# _6Ukd8pqlEeGSON8vddiWzQ_1919731713.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the level of an account within the account hierarchy.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountLevelCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6Ukd8pqlEeGSON8vddiWzQ_1919731713")]
public partial class AccountLevelCodeDropdownSource : EnumMetadataManager<AccountLevelCode,IAccountLevelCodeDropdownRow,AccountLevelCodeDropdownRow>
{
    public AccountLevelCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountLevelCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
