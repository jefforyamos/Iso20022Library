﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExtendedEventType3Code.  ISO2002 ID# _JpJNUJ5REeWsgrkrngh7Ew.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExtendedEventType3CodeDropdownSource"/>.
/// Implements <seealso cref="IExtendedEventType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JpJNUJ5REeWsgrkrngh7Ew")]
public partial class ExtendedEventType3CodeDropdownRow : EnumMetadataItem<ExtendedEventType3Code>, IExtendedEventType3CodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExtendedEventType3CodeDropdownRow(ExtendedEventType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
