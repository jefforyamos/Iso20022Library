﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StatusCode.  ISO2002 ID# _YgFIuNp-Ed-ak6NoX_4Aeg_-740656164.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StatusCodeDropdownSource"/>.
/// Implements <seealso cref="IStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YgFIuNp-Ed-ak6NoX_4Aeg_-740656164")]
public partial class StatusCodeDropdownRow : EnumMetadataItem<StatusCode>, IStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StatusCodeDropdownRow(StatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
