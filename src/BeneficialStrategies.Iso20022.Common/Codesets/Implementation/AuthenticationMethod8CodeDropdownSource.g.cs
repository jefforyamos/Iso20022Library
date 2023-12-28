﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthenticationMethod8Code.  ISO2002 ID# _8I3roNtmEeipuvJHTHIw9A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method to authenticate the customer or its card.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthenticationMethod8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8I3roNtmEeipuvJHTHIw9A")]
public partial class AuthenticationMethod8CodeDropdownSource : EnumMetadataManager<AuthenticationMethod8Code,IAuthenticationMethod8CodeDropdownRow,AuthenticationMethod8CodeDropdownRow>
{
    public AuthenticationMethod8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthenticationMethod8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
