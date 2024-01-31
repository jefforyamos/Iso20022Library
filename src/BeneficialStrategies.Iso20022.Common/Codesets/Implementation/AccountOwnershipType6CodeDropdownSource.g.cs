﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountOwnershipType6Code.  ISO2002 ID# _NptcQDOQEeqjy7_SkdcoGg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account ownership.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountOwnershipType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NptcQDOQEeqjy7_SkdcoGg")]
public partial class AccountOwnershipType6CodeDropdownSource : EnumMetadataManager<AccountOwnershipType6Code,IAccountOwnershipType6CodeDropdownRow,AccountOwnershipType6CodeDropdownRow>
{
    public AccountOwnershipType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountOwnershipType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
