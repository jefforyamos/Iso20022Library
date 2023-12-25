﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RetailerResultDetailCode.  ISO2002 ID# _OzDOwNxXEeioifFt1dhnJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the processing of the message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RetailerResultDetailCodeDropdownSource"/>.
/// Implements <seealso cref="IRetailerResultDetailCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OzDOwNxXEeioifFt1dhnJA")]
public partial class RetailerResultDetailCodeDropdownRow : EnumMetadataItem<RetailerResultDetailCode>, IRetailerResultDetailCodeDropdownRow
{
    /// <summary>
    /// Result of the processing of the message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RetailerResultDetailCodeDropdownRow(RetailerResultDetailCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
