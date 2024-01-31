﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthenticationMethodCode.  ISO2002 ID# _TV8F4AEcEeCQm6a_G2yO_w_-487459684.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used to authenticate a cardholder.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthenticationMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TV8F4AEcEeCQm6a_G2yO_w_-487459684")]
public partial class AuthenticationMethodCodeDropdownSource : EnumMetadataManager<AuthenticationMethodCode,IAuthenticationMethodCodeDropdownRow,AuthenticationMethodCodeDropdownRow>
{
    public AuthenticationMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthenticationMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
