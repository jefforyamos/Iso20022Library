﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for IntendedOrActualCode.  ISO2002 ID# _lko5sDcjEeidBoT_PugKiA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if a charge or cost is intended (ex ante) or actual (post ante).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="IntendedOrActualCodeDropdownSource"/>.
/// Implements <seealso cref="IIntendedOrActualCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lko5sDcjEeidBoT_PugKiA")]
public partial class IntendedOrActualCodeDropdownRow : EnumMetadataItem<IntendedOrActualCode>, IIntendedOrActualCodeDropdownRow
{
    /// <summary>
    /// Specifies if a charge or cost is intended (ex ante) or actual (post ante).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public IntendedOrActualCodeDropdownRow(IntendedOrActualCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
