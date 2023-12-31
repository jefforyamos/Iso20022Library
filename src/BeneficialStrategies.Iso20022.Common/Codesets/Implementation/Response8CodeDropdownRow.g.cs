﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Response8Code.  ISO2002 ID# _cKXU0Ji4EeefZKJHxQTztg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Response codes.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Response8CodeDropdownSource"/>.
/// Implements <seealso cref="IResponse8CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cKXU0Ji4EeefZKJHxQTztg")]
public partial class Response8CodeDropdownRow : EnumMetadataItem<Response8Code>, IResponse8CodeDropdownRow
{
    /// <summary>
    /// Response codes.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Response8CodeDropdownRow(Response8Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
