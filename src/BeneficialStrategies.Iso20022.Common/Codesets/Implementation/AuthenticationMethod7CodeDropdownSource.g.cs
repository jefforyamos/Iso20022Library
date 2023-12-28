﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthenticationMethod7Code.  ISO2002 ID# _8QhnAIoaEeSirOZJBRz_nA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method to authenticate the customer or its card.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthenticationMethod7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8QhnAIoaEeSirOZJBRz_nA")]
public partial class AuthenticationMethod7CodeDropdownSource : EnumMetadataManager<AuthenticationMethod7Code,IAuthenticationMethod7CodeDropdownRow,AuthenticationMethod7CodeDropdownRow>
{
    public AuthenticationMethod7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthenticationMethod7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}