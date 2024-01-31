﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AuthenticationEntity1Code.  ISO2002 ID# _TSESjQEcEeCQm6a_G2yO_w_-1884722384.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Entity or object in charge of verifying the cardholder authenticity.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AuthenticationEntity1CodeDropdownSource"/>.
/// Implements <seealso cref="IAuthenticationEntity1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TSESjQEcEeCQm6a_G2yO_w_-1884722384")]
public partial class AuthenticationEntity1CodeDropdownRow : EnumMetadataItem<AuthenticationEntity1Code>, IAuthenticationEntity1CodeDropdownRow
{
    /// <summary>
    /// Entity or object in charge of verifying the cardholder authenticity.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AuthenticationEntity1CodeDropdownRow(AuthenticationEntity1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
