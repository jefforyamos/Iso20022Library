﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TR34CommandCode.  ISO2002 ID# _hWYrAF2iEeekzJIz1JxYSQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specific TR34 command that the ATM could perform.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TR34CommandCodeDropdownSource"/>.
/// Implements <seealso cref="ITR34CommandCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hWYrAF2iEeekzJIz1JxYSQ")]
public partial class TR34CommandCodeDropdownRow : EnumMetadataItem<TR34CommandCode>, ITR34CommandCodeDropdownRow
{
    /// <summary>
    /// Specific TR34 command that the ATM could perform.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TR34CommandCodeDropdownRow(TR34CommandCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}