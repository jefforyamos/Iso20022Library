﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RequestStatusCode.  ISO2002 ID# _ZUFYg9p-Ed-ak6NoX_4Aeg_1488265087.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the coded status of invoice financing request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RequestStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IRequestStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZUFYg9p-Ed-ak6NoX_4Aeg_1488265087")]
public partial class RequestStatusCodeDropdownRow : EnumMetadataItem<RequestStatusCode>, IRequestStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the coded status of invoice financing request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RequestStatusCodeDropdownRow(RequestStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
