﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthenticationEntity1Code.  ISO2002 ID# _TSESjQEcEeCQm6a_G2yO_w_-1884722384.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Entity or object in charge of verifying the cardholder authenticity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthenticationEntity1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TSESjQEcEeCQm6a_G2yO_w_-1884722384")]
public partial class AuthenticationEntity1CodeDropdownSource : EnumMetadataManager<AuthenticationEntity1Code,IAuthenticationEntity1CodeDropdownRow,AuthenticationEntity1CodeDropdownRow>
{
    public AuthenticationEntity1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthenticationEntity1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
