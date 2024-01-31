﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthenticationEntity2Code.  ISO2002 ID# _arLtkWjoEeSDR-pyia6Xtg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Entity or device that has performed the verification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthenticationEntity2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_arLtkWjoEeSDR-pyia6Xtg")]
public partial class AuthenticationEntity2CodeDropdownSource : EnumMetadataManager<AuthenticationEntity2Code,IAuthenticationEntity2CodeDropdownRow,AuthenticationEntity2CodeDropdownRow>
{
    public AuthenticationEntity2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthenticationEntity2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
