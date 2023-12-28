﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountChoiceMethod1Code.  ISO2002 ID# _f52cQHs7EeSTS7uHCe8FPQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method used by the cardholder and the terminal for the choice of the account.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountChoiceMethod1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_f52cQHs7EeSTS7uHCe8FPQ")]
public partial class AccountChoiceMethod1CodeDropdownSource : EnumMetadataManager<AccountChoiceMethod1Code,IAccountChoiceMethod1CodeDropdownRow,AccountChoiceMethod1CodeDropdownRow>
{
    public AccountChoiceMethod1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountChoiceMethod1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
