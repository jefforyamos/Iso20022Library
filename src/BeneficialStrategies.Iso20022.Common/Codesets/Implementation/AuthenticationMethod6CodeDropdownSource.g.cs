﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthenticationMethod6Code.  ISO2002 ID# _pBFH8YIJEeS7UOLM47txvA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Methods used to authenticate a person or a card.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthenticationMethod6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pBFH8YIJEeS7UOLM47txvA")]
public partial class AuthenticationMethod6CodeDropdownSource : EnumMetadataManager<AuthenticationMethod6Code,IAuthenticationMethod6CodeDropdownRow,AuthenticationMethod6CodeDropdownRow>
{
    public AuthenticationMethod6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthenticationMethod6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}