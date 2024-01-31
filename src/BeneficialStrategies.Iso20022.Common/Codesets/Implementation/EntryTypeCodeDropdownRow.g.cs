﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EntryTypeCode.  ISO2002 ID# _GwgOMHvEEemW9qhOy0scyg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the quantity or amount is to be delivered or received.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EntryTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IEntryTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GwgOMHvEEemW9qhOy0scyg")]
public partial class EntryTypeCodeDropdownRow : EnumMetadataItem<EntryTypeCode>, IEntryTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies whether the quantity or amount is to be delivered or received.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EntryTypeCodeDropdownRow(EntryTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
