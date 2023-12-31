﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CutOffCode.  ISO2002 ID# _1oYawzL3EeKU9IrkkToqcw_1347831784.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cut-off type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CutOffCodeDropdownSource"/>.
/// Implements <seealso cref="ICutOffCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1oYawzL3EeKU9IrkkToqcw_1347831784")]
public partial class CutOffCodeDropdownRow : EnumMetadataItem<CutOffCode>, ICutOffCodeDropdownRow
{
    /// <summary>
    /// Specifies the cut-off type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CutOffCodeDropdownRow(CutOffCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
