﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Response2Code.  ISO2002 ID# _40Uz0GqHEeS8RZDTbvnB_A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Response to a request of service.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Response2CodeDropdownSource"/>.
/// Implements <seealso cref="IResponse2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_40Uz0GqHEeS8RZDTbvnB_A")]
public partial class Response2CodeDropdownRow : EnumMetadataItem<Response2Code>, IResponse2CodeDropdownRow
{
    /// <summary>
    /// Response to a request of service.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Response2CodeDropdownRow(Response2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
