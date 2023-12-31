﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExtendedEventTypeCode.  ISO2002 ID# _1mchFTL3EeKU9IrkkToqcw_1589826234.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExtendedEventTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IExtendedEventTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1mchFTL3EeKU9IrkkToqcw_1589826234")]
public partial class ExtendedEventTypeCodeDropdownRow : EnumMetadataItem<ExtendedEventTypeCode>, IExtendedEventTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExtendedEventTypeCodeDropdownRow(ExtendedEventTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
