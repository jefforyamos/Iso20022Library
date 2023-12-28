﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthenticationEntityCode.  ISO2002 ID# _TVyU7AEcEeCQm6a_G2yO_w_1327141076.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Entity or object in charge of verifying the cardholder authenticity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthenticationEntityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVyU7AEcEeCQm6a_G2yO_w_1327141076")]
public partial class AuthenticationEntityCodeDropdownSource : EnumMetadataManager<AuthenticationEntityCode,IAuthenticationEntityCodeDropdownRow,AuthenticationEntityCodeDropdownRow>
{
    public AuthenticationEntityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthenticationEntityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}