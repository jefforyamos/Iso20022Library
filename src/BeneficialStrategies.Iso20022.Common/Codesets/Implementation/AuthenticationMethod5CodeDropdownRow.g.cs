﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AuthenticationMethod5Code.  ISO2002 ID# _TdCfEYIGEeS7UOLM47txvA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Methods used to authenticate a person or a card.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AuthenticationMethod5CodeDropdownSource"/>.
/// Implements <seealso cref="IAuthenticationMethod5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TdCfEYIGEeS7UOLM47txvA")]
public partial class AuthenticationMethod5CodeDropdownRow : EnumMetadataItem<AuthenticationMethod5Code>, IAuthenticationMethod5CodeDropdownRow
{
    /// <summary>
    /// Methods used to authenticate a person or a card.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AuthenticationMethod5CodeDropdownRow(AuthenticationMethod5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
