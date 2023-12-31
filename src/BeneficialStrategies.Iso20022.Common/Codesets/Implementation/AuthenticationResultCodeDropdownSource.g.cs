﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthenticationResultCode.  ISO2002 ID# _Zg1qsLABEeah1_v59tW6Rg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of authentication done.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthenticationResultCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zg1qsLABEeah1_v59tW6Rg")]
public partial class AuthenticationResultCodeDropdownSource : EnumMetadataManager<AuthenticationResultCode,IAuthenticationResultCodeDropdownRow,AuthenticationResultCodeDropdownRow>
{
    public AuthenticationResultCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthenticationResultCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
