﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingReason10Code.  ISO2002 ID# _b_fWsf41EeClUvPNHKL9Zw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending settlement. Settlement on the instructed settlement date is still possible.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingReason10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_b_fWsf41EeClUvPNHKL9Zw")]
public partial class PendingReason10CodeDropdownSource : EnumMetadataManager<PendingReason10Code,IPendingReason10CodeDropdownRow,PendingReason10CodeDropdownRow>
{
    public PendingReason10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingReason10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
