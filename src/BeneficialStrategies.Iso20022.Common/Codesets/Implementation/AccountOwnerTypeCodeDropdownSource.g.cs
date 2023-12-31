﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountOwnerTypeCode.  ISO2002 ID# _r1Jf8I8mEeeBmcwCTnMfBg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account owner.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountOwnerTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_r1Jf8I8mEeeBmcwCTnMfBg")]
public partial class AccountOwnerTypeCodeDropdownSource : EnumMetadataManager<AccountOwnerTypeCode,IAccountOwnerTypeCodeDropdownRow,AccountOwnerTypeCodeDropdownRow>
{
    public AccountOwnerTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountOwnerTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
