﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TriggerAction1Code.  ISO2002 ID# _YvuHNtp-Ed-ak6NoX_4Aeg_-901469544.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of action to take when the trigger hits.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITriggerAction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YvuHNtp-Ed-ak6NoX_4Aeg_-901469544")]
public partial class TriggerAction1CodeDropdownSource : EnumMetadataManager<TriggerAction1Code,ITriggerAction1CodeDropdownRow,TriggerAction1CodeDropdownRow>
{
    public TriggerAction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TriggerAction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
