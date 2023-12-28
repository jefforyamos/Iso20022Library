﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExtendedEventType4Code.  ISO2002 ID# _-mm30ZESEeajS_7NioJdVA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExtendedEventType4CodeDropdownSource"/>.
/// Implements <seealso cref="IExtendedEventType4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-mm30ZESEeajS_7NioJdVA")]
public partial class ExtendedEventType4CodeDropdownRow : EnumMetadataItem<ExtendedEventType4Code>, IExtendedEventType4CodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExtendedEventType4CodeDropdownRow(ExtendedEventType4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}