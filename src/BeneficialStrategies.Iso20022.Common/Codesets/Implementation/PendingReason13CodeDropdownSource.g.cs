﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingReason13Code.  ISO2002 ID# _wtDRwFhfEeSsH9MSoogb7Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingReason13CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wtDRwFhfEeSsH9MSoogb7Q")]
public partial class PendingReason13CodeDropdownSource : EnumMetadataManager<PendingReason13Code,IPendingReason13CodeDropdownRow,PendingReason13CodeDropdownRow>
{
    public PendingReason13CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingReason13CodeDropdownRow(enumValue, memberInfo))
    {
    }
}