﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AuthenticationEntity2Code.  ISO2002 ID# _arLtkWjoEeSDR-pyia6Xtg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Entity or device that has performed the verification.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AuthenticationEntity2CodeDropdownSource"/>.
/// Implements <seealso cref="IAuthenticationEntity2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_arLtkWjoEeSDR-pyia6Xtg")]
public partial class AuthenticationEntity2CodeDropdownRow : EnumMetadataItem<AuthenticationEntity2Code>, IAuthenticationEntity2CodeDropdownRow
{
    /// <summary>
    /// Entity or device that has performed the verification.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AuthenticationEntity2CodeDropdownRow(AuthenticationEntity2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
