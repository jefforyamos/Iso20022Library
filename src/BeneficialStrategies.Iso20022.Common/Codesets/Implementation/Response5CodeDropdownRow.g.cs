﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Response5Code.  ISO2002 ID# _qSYuMNxWEeioifFt1dhnJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the processing of the message
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Response5CodeDropdownSource"/>.
/// Implements <seealso cref="IResponse5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qSYuMNxWEeioifFt1dhnJA")]
public partial class Response5CodeDropdownRow : EnumMetadataItem<Response5Code>, IResponse5CodeDropdownRow
{
    /// <summary>
    /// Result of the processing of the message
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Response5CodeDropdownRow(Response5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
