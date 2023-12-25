﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TriggerTypeCode.  ISO2002 ID# _YwUkIdp-Ed-ak6NoX_4Aeg_-70363813.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines when the trigger will hit, i.e. the action specified by the trigger instructions will come into effect.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TriggerTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ITriggerTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YwUkIdp-Ed-ak6NoX_4Aeg_-70363813")]
public partial class TriggerTypeCodeDropdownRow : EnumMetadataItem<TriggerTypeCode>, ITriggerTypeCodeDropdownRow
{
    /// <summary>
    /// Defines when the trigger will hit, i.e. the action specified by the trigger instructions will come into effect.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TriggerTypeCodeDropdownRow(TriggerTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
