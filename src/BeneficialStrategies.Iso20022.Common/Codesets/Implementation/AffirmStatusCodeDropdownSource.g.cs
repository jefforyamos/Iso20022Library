﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AffirmStatusCode.  ISO2002 ID# _wZYWYESsEeSTS-T7FO4CUQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the status of the confirmation acknowledgement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAffirmStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wZYWYESsEeSTS-T7FO4CUQ")]
public partial class AffirmStatusCodeDropdownSource : EnumMetadataManager<AffirmStatusCode,IAffirmStatusCodeDropdownRow,AffirmStatusCodeDropdownRow>
{
    public AffirmStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AffirmStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
