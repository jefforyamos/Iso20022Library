﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TriggerActionCode.  ISO2002 ID# _Yv34Mtp-Ed-ak6NoX_4Aeg_-920863827.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of action to take when the trigger hits.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITriggerActionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yv34Mtp-Ed-ak6NoX_4Aeg_-920863827")]
public partial class TriggerActionCodeDropdownSource : EnumMetadataManager<TriggerActionCode,ITriggerActionCodeDropdownRow,TriggerActionCodeDropdownRow>
{
    public TriggerActionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TriggerActionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
