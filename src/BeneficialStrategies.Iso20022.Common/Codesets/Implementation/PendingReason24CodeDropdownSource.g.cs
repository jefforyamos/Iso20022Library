﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingReason24Code.  ISO2002 ID# _NklMbCW-EeygjNFjAlVoPA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending settlement. Settlement on the instructed settlement date is still possible.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingReason24CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NklMbCW-EeygjNFjAlVoPA")]
public partial class PendingReason24CodeDropdownSource : EnumMetadataManager<PendingReason24Code,IPendingReason24CodeDropdownRow,PendingReason24CodeDropdownRow>
{
    public PendingReason24CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingReason24CodeDropdownRow(enumValue, memberInfo))
    {
    }
}