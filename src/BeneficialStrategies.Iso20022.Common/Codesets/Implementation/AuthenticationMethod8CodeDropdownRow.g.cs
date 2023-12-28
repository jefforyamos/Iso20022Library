﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AuthenticationMethod8Code.  ISO2002 ID# _8I3roNtmEeipuvJHTHIw9A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method to authenticate the customer or its card.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AuthenticationMethod8CodeDropdownSource"/>.
/// Implements <seealso cref="IAuthenticationMethod8CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8I3roNtmEeipuvJHTHIw9A")]
public partial class AuthenticationMethod8CodeDropdownRow : EnumMetadataItem<AuthenticationMethod8Code>, IAuthenticationMethod8CodeDropdownRow
{
    /// <summary>
    /// Method to authenticate the customer or its card.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AuthenticationMethod8CodeDropdownRow(AuthenticationMethod8Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}