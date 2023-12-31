﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AuthenticationMethod7Code.  ISO2002 ID# _8QhnAIoaEeSirOZJBRz_nA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method to authenticate the customer or its card.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AuthenticationMethod7CodeDropdownSource"/>.
/// Implements <seealso cref="IAuthenticationMethod7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8QhnAIoaEeSirOZJBRz_nA")]
public partial class AuthenticationMethod7CodeDropdownRow : EnumMetadataItem<AuthenticationMethod7Code>, IAuthenticationMethod7CodeDropdownRow
{
    /// <summary>
    /// Method to authenticate the customer or its card.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AuthenticationMethod7CodeDropdownRow(AuthenticationMethod7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
