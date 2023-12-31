﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Priority1Code.  ISO2002 ID# _aKLTANp-Ed-ak6NoX_4Aeg_-636884160.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the priority level of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Priority1CodeDropdownSource"/>.
/// Implements <seealso cref="IPriority1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aKLTANp-Ed-ak6NoX_4Aeg_-636884160")]
public partial class Priority1CodeDropdownRow : EnumMetadataItem<Priority1Code>, IPriority1CodeDropdownRow
{
    /// <summary>
    /// Specifies the priority level of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Priority1CodeDropdownRow(Priority1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
