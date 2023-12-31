﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AuthorisationCode.  ISO2002 ID# _bjlV8Np-Ed-ak6NoX_4Aeg_-1874566431.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AuthorisationCodeDropdownSource"/>.
/// Implements <seealso cref="IAuthorisationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bjlV8Np-Ed-ak6NoX_4Aeg_-1874566431")]
public partial class AuthorisationCodeDropdownRow : EnumMetadataItem<AuthorisationCode>, IAuthorisationCodeDropdownRow
{
    /// <summary>
    /// Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AuthorisationCodeDropdownRow(AuthorisationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
