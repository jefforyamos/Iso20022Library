﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PairedReconciledV2Code.  ISO2002 ID# _YsCg1ph8EeumhIk_Pv20Lg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Common report status for all individual reports sent / received.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPairedReconciledV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YsCg1ph8EeumhIk_Pv20Lg")]
public partial class PairedReconciledV2CodeDropdownSource : EnumMetadataManager<PairedReconciledV2Code,IPairedReconciledV2CodeDropdownRow,PairedReconciledV2CodeDropdownRow>
{
    public PairedReconciledV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PairedReconciledV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
