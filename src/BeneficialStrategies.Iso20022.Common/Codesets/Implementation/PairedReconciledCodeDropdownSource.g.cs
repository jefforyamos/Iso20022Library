﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PairedReconciledCode.  ISO2002 ID# _8y6XACmsEeerta_tWXAsWQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Common report status for all individual reports sent / received.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPairedReconciledCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8y6XACmsEeerta_tWXAsWQ")]
public partial class PairedReconciledCodeDropdownSource : EnumMetadataManager<PairedReconciledCode,IPairedReconciledCodeDropdownRow,PairedReconciledCodeDropdownRow>
{
    public PairedReconciledCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PairedReconciledCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
