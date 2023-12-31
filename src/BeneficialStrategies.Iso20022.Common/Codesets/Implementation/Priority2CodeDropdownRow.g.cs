﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Priority2Code.  ISO2002 ID# _aKLTBNp-Ed-ak6NoX_4Aeg_-581472374.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the priority level of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Priority2CodeDropdownSource"/>.
/// Implements <seealso cref="IPriority2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aKLTBNp-Ed-ak6NoX_4Aeg_-581472374")]
public partial class Priority2CodeDropdownRow : EnumMetadataItem<Priority2Code>, IPriority2CodeDropdownRow
{
    /// <summary>
    /// Specifies the priority level of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Priority2CodeDropdownRow(Priority2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
