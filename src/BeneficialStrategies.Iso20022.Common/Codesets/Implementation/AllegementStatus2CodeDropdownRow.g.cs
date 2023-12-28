﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AllegementStatus2Code.  ISO2002 ID# _6eJ1kK3DEeeBVbuVcoH9Nw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an allegement.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AllegementStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="IAllegementStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6eJ1kK3DEeeBVbuVcoH9Nw")]
public partial class AllegementStatus2CodeDropdownRow : EnumMetadataItem<AllegementStatus2Code>, IAllegementStatus2CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an allegement.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AllegementStatus2CodeDropdownRow(AllegementStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
