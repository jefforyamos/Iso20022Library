﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthenticationResult1Code.  ISO2002 ID# _rETL4Pm3EeaYndR2y_Ep9g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of authentication done.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthenticationResult1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rETL4Pm3EeaYndR2y_Ep9g")]
public partial class AuthenticationResult1CodeDropdownSource : EnumMetadataManager<AuthenticationResult1Code,IAuthenticationResult1CodeDropdownRow,AuthenticationResult1CodeDropdownRow>
{
    public AuthenticationResult1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthenticationResult1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}