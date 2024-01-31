﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StatusSubType1Code.  ISO2002 ID# _8VSYwB3cEeKXIbeXfdPzuw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the sub status of the trade notification.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StatusSubType1CodeDropdownSource"/>.
/// Implements <seealso cref="IStatusSubType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8VSYwB3cEeKXIbeXfdPzuw")]
public partial class StatusSubType1CodeDropdownRow : EnumMetadataItem<StatusSubType1Code>, IStatusSubType1CodeDropdownRow
{
    /// <summary>
    /// Indicates the sub status of the trade notification.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StatusSubType1CodeDropdownRow(StatusSubType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
