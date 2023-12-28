﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ResponseModeV2Code.  ISO2002 ID# _UvDdAFDiEeuzhPLt3qllKA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Message response awaited by the initiator of the Request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ResponseModeV2CodeDropdownSource"/>.
/// Implements <seealso cref="IResponseModeV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UvDdAFDiEeuzhPLt3qllKA")]
public partial class ResponseModeV2CodeDropdownRow : EnumMetadataItem<ResponseModeV2Code>, IResponseModeV2CodeDropdownRow
{
    /// <summary>
    /// Message response awaited by the initiator of the Request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ResponseModeV2CodeDropdownRow(ResponseModeV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}