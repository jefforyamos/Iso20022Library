﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SenderTriggerCode.  ISO2002 ID# _hy2h4MmLEeWAGphE2LvqeA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the trigger code used by the sender to generate the file.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISenderTriggerCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hy2h4MmLEeWAGphE2LvqeA")]
public partial class SenderTriggerCodeDropdownSource : EnumMetadataManager<SenderTriggerCode,ISenderTriggerCodeDropdownRow,SenderTriggerCodeDropdownRow>
{
    public SenderTriggerCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SenderTriggerCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
