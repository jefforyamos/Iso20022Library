﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExtendedEventType2Code.  ISO2002 ID# _ZcengHniEeO2o_OAyvnbZw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExtendedEventType2CodeDropdownSource"/>.
/// Implements <seealso cref="IExtendedEventType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZcengHniEeO2o_OAyvnbZw")]
public partial class ExtendedEventType2CodeDropdownRow : EnumMetadataItem<ExtendedEventType2Code>, IExtendedEventType2CodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExtendedEventType2CodeDropdownRow(ExtendedEventType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
