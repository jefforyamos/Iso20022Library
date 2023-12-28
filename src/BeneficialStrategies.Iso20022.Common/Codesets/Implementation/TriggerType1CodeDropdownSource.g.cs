﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TriggerType1Code.  ISO2002 ID# _YwKzJdp-Ed-ak6NoX_4Aeg_159326277.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines when the trigger will hit, i.e. the action specified by the trigger instructions will come into effect.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITriggerType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YwKzJdp-Ed-ak6NoX_4Aeg_159326277")]
public partial class TriggerType1CodeDropdownSource : EnumMetadataManager<TriggerType1Code,ITriggerType1CodeDropdownRow,TriggerType1CodeDropdownRow>
{
    public TriggerType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TriggerType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
