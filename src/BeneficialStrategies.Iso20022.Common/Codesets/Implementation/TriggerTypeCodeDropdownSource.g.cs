﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TriggerTypeCode.  ISO2002 ID# _YwUkIdp-Ed-ak6NoX_4Aeg_-70363813.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines when the trigger will hit, i.e. the action specified by the trigger instructions will come into effect.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITriggerTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YwUkIdp-Ed-ak6NoX_4Aeg_-70363813")]
public partial class TriggerTypeCodeDropdownSource : EnumMetadataManager<TriggerTypeCode,ITriggerTypeCodeDropdownRow,TriggerTypeCodeDropdownRow>
{
    public TriggerTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TriggerTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}