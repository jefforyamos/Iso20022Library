﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for NoticeTypeCode.  ISO2002 ID# _1oOpwzL3EeKU9IrkkToqcw_800966479.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined notice type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="NoticeTypeCodeDropdownSource"/>.
/// Implements <seealso cref="INoticeTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1oOpwzL3EeKU9IrkkToqcw_800966479")]
public partial class NoticeTypeCodeDropdownRow : EnumMetadataItem<NoticeTypeCode>, INoticeTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) defined notice type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public NoticeTypeCodeDropdownRow(NoticeTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
