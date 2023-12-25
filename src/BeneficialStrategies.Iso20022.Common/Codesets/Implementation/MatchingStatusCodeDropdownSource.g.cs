﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MatchingStatusCode.  ISO2002 ID# _aVDGRtp-Ed-ak6NoX_4Aeg_162716149.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the matching status of the instruction at the time the settlement instruction was sent.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMatchingStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aVDGRtp-Ed-ak6NoX_4Aeg_162716149")]
public partial class MatchingStatusCodeDropdownSource : EnumMetadataManager<MatchingStatusCode,IMatchingStatusCodeDropdownRow,MatchingStatusCodeDropdownRow>
{
    public MatchingStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MatchingStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
