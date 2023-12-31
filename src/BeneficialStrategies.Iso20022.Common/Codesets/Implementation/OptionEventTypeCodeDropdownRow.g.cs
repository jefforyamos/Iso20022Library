﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OptionEventTypeCode.  ISO2002 ID# _TGmBAcR0EeOg-a7zWL_U0A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of event for an option.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OptionEventTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IOptionEventTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TGmBAcR0EeOg-a7zWL_U0A")]
public partial class OptionEventTypeCodeDropdownRow : EnumMetadataItem<OptionEventTypeCode>, IOptionEventTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of event for an option.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OptionEventTypeCodeDropdownRow(OptionEventTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
