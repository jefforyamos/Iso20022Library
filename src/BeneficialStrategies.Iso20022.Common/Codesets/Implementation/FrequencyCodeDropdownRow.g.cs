﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FrequencyCode.  ISO2002 ID# _asTIqdp-Ed-ak6NoX_4Aeg_-2101415313.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FrequencyCodeDropdownSource"/>.
/// Implements <seealso cref="IFrequencyCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_asTIqdp-Ed-ak6NoX_4Aeg_-2101415313")]
public partial class FrequencyCodeDropdownRow : EnumMetadataItem<FrequencyCode>, IFrequencyCodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FrequencyCodeDropdownRow(FrequencyCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
