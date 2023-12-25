﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BookPriorityIndicatorCode.  ISO2002 ID# _bVIDMtp-Ed-ak6NoX_4Aeg_335335591.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if a Cancel/Replace instruction has caused an order to loose its book priority.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BookPriorityIndicatorCodeDropdownSource"/>.
/// Implements <seealso cref="IBookPriorityIndicatorCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bVIDMtp-Ed-ak6NoX_4Aeg_335335591")]
public partial class BookPriorityIndicatorCodeDropdownRow : EnumMetadataItem<BookPriorityIndicatorCode>, IBookPriorityIndicatorCodeDropdownRow
{
    /// <summary>
    /// Indicates if a Cancel/Replace instruction has caused an order to loose its book priority.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BookPriorityIndicatorCodeDropdownRow(BookPriorityIndicatorCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
